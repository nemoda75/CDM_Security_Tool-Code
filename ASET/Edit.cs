using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace ASET
{
    public partial class Edit : MaterialForm
    {
        public static ListView lvw;
        public static int index;
        public static bool isAdd;

        public Edit(string query, ListView p_lvw, int p_index, bool p_isAdd, ListView check_result_lvw, bool need_recommendation)
        {
            InitializeComponent();

            // [1] 매터리얼 디자인 적용
            if (Main.theme_state == "Dark")
            {
                // * 매터리얼 다크 테마 적용
                Materia_Theme theme = new Materia_Theme();
                theme.Apply_Dark_Material_Skin(this, null);
            }
            else
            {
                // * 매터리얼 밝은 테마 적용
                Materia_Theme theme = new Materia_Theme();
                theme.Apply_Light_Material_Skin(this, null);
            }

            // [1.5] 한국어 적용
            if (Main.isKoreanMode)
            {
                this.recommend_lbl.Text = "추천어";
                this.back_btn.Text = "뒤로";
                this.save_btn.Text = "저장";
            }


            // [2] 리스트 박스 디자인
            this.recommendation_lvw.View = View.Details;
            this.recommendation_lvw.HideSelection = true;
            this.recommendation_lvw.HeaderStyle = ColumnHeaderStyle.None;
            ColumnHeader h = new ColumnHeader();
            h.Width = this.recommendation_lvw.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;
            this.recommendation_lvw.Columns.Add(h);


            // [3] 폼에 데이터를 채움
            editor_tbx.Text = query;
            lvw = p_lvw;
            index = p_index;
            isAdd = p_isAdd;

            // recommend
            if (need_recommendation)
            {
                if (check_result_lvw != null)
                {
                    if (!String.IsNullOrEmpty(query))
                    {
                        int start_index = query.IndexOf("<");
                        int end_index = query.IndexOf(">");

                        if (start_index != -1 && end_index != -1)
                        {
                            foreach (ListViewItem item in check_result_lvw.Items)
                            {
                                string result = item.SubItems[2].Text;

                                if (result == "(no data)" || result.Contains("Exception"))
                                {
                                    continue;
                                }

                                this.recommendation_lvw.Items.Add(result);
                            }
                        }
                    }
                }
            }

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string query = this.editor_tbx.Text;

            Rule_Detail parent = (Rule_Detail)this.Owner;
            parent.Edit_Query(query, lvw, index, isAdd);

            this.Close();
        }

        private void recommendation_lvw_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (recommendation_lvw.FocusedItem == null)
            {
                MessageBox.Show("수정하고자 하는 쿼리를 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string recommended_word = recommendation_lvw.FocusedItem.SubItems[0].Text;
            string query = this.editor_tbx.Text;

            if (!String.IsNullOrEmpty(query))
            {
                int start_index = query.IndexOf("<");
                int end_index = query.IndexOf(">");

                if (start_index != -1 && end_index != -1)
                {
                    if (MessageBox.Show("선택한 추천어로 변수 부분을 대체할까요?", "Question", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }

                    this.editor_tbx.Text = query.Replace(query.Substring(start_index, (end_index - start_index)+1), recommended_word);
                }


            }

        }
    }
}
