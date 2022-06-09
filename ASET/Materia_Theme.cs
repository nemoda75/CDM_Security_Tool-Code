using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASET
{
    class Materia_Theme
    {
        public void Apply_Light_Material_Skin(MaterialForm frm, DataGridView dgrv)
        {
            // [1] 밝은 테마로 변경 
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(frm);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.Orange100, TextShade.WHITE);

            materialSkinManager.ROBOTO_MEDIUM_12 = new Font("맑은 고딕", 18, FontStyle.Bold);


            if (Main.isKoreanMode)
            {
                materialSkinManager.ROBOTO_MEDIUM_10 = new Font("맑은 고딕", 11, FontStyle.Bold);
                materialSkinManager.ROBOTO_REGULAR_11 = new Font("맑은 고딕", 12, FontStyle.Bold);


            }
            else
            {
                materialSkinManager.ROBOTO_MEDIUM_10 = new Font("맑은 고딕", 11, FontStyle.Bold);
                materialSkinManager.ROBOTO_REGULAR_11 = new Font("맑은 고딕", 12, FontStyle.Bold);
            }

            materialSkinManager.FORM_PADDING = 14;

            if (dgrv == null) { return; }

            // [2] 매터리얼 데이터 그리드 뷰 디자인
            dgrv.BorderStyle = BorderStyle.None;
            dgrv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgrv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(189, 226, 255);
            dgrv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgrv.BackgroundColor = Color.White;
            dgrv.Font = new Font("맑은 고딕", 12, FontStyle.Regular);

            dgrv.EnableHeadersVisualStyles = false;
            dgrv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgrv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            dgrv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgrv.ColumnHeadersDefaultCellStyle.Font = new Font("맑은 고딕", 12, FontStyle.Bold);

            if (Main.isKoreanMode)
            {
                dgrv.ColumnHeadersDefaultCellStyle.Font = new Font("맑은 고딕", 12, FontStyle.Bold);

            }
            else
            {
                dgrv.ColumnHeadersDefaultCellStyle.Font = new Font("맑은 고딕", 12, FontStyle.Bold);
            }
        }

        public void Apply_Dark_Material_Skin(MaterialForm frm, DataGridView dgrv)
        {
            // [1] 다크 테마로 변경
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(frm);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            if (dgrv == null) { return; }

            // [2] 매터리얼 데이터 그리드 뷰 디자인
            dgrv.BorderStyle = BorderStyle.None;
            dgrv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgrv.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgrv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgrv.BackgroundColor = Color.White;
            dgrv.Font = new Font("맑은 고딕", 12, FontStyle.Regular);

            dgrv.EnableHeadersVisualStyles = false;
            dgrv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgrv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            dgrv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgrv.ColumnHeadersDefaultCellStyle.Font = new Font("맑은 고딕", 12, FontStyle.Regular);
        }
    }
}
