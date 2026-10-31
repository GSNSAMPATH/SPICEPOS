namespace HardwarePOS.UI.Helpers
{
    public static class UITheme
    {
        // =====================================================
        // COLORS
        // =====================================================

        public static Color BackgroundColor =>
            Color.FromArgb(248, 250, 252);

        public static Color SurfaceColor =>
            Color.White;

        public static Color PrimaryColor =>
            Color.FromArgb(37, 99, 235);

        public static Color PrimaryHoverColor =>
            Color.FromArgb(29, 78, 216);

        public static Color SuccessColor =>
            Color.FromArgb(34, 197, 94);

        public static Color DangerColor =>
            Color.FromArgb(239, 68, 68);

        public static Color DangerHoverColor =>
            Color.FromArgb(220, 38, 38);

        public static Color WarningColor =>
            Color.FromArgb(245, 158, 11);

        public static Color BorderColor =>
            Color.FromArgb(229, 231, 235);

        public static Color TextDark =>
            Color.FromArgb(17, 24, 39);

        public static Color TextGray =>
            Color.FromArgb(107, 114, 128);

        public static Color SelectedRowColor =>
            Color.FromArgb(219, 234, 254);

        // =====================================================
        // FONTS
        // =====================================================

        public static Font TitleFont =>
            new Font(
                "Segoe UI Semibold",
                22F,
                FontStyle.Bold);

        public static Font HeaderFont =>
            new Font(
                "Segoe UI Semibold",
                10F,
                FontStyle.Bold);

        public static Font NormalFont =>
            new Font(
                "Segoe UI",
                10F);

        public static Font CardValueFont =>
            new Font(
                "Segoe UI Semibold",
                20F,
                FontStyle.Bold);

        public static Font CardTitleFont =>
            new Font(
                "Segoe UI",
                10F);

        // =====================================================
        // FORM
        // =====================================================

        public static void StyleForm(
            Form form)
        {
            form.BackColor =
                BackgroundColor;

            form.Font =
                NormalFont;

            form.StartPosition =
                FormStartPosition.CenterScreen;
        }

        // =====================================================
        // LABELS
        // =====================================================

        public static void StylePageTitle(
            Label label)
        {
            label.Font =
                TitleFont;

            label.ForeColor =
                TextDark;
        }

        public static void StyleSecondaryLabel(
            Label label)
        {
            label.Font =
                NormalFont;

            label.ForeColor =
                TextGray;
        }

        // =====================================================
        // PANELS / CARDS
        // =====================================================

        public static void StyleCard(
            Panel panel)
        {
            panel.BackColor =
                SurfaceColor;

            panel.BorderStyle =
                BorderStyle.FixedSingle;
        }

        public static void StyleContainer(
            Panel panel)
        {
            panel.BackColor =
                SurfaceColor;
        }

        // =====================================================
        // KPI CARD
        // =====================================================

        public static void StyleKpiValue(
            Label label)
        {
            label.Font =
                CardValueFont;

            label.ForeColor =
                TextDark;
        }

        public static void StyleKpiTitle(
            Label label)
        {
            label.Font =
                CardTitleFont;

            label.ForeColor =
                TextGray;
        }

        // =====================================================
        // BUTTONS
        // =====================================================

        public static void StylePrimaryButton(
            Button button)
        {
            button.BackColor =
                PrimaryColor;

            button.ForeColor =
                Color.White;

            button.FlatStyle =
                FlatStyle.Flat;

            button.FlatAppearance.BorderSize = 0;

            button.FlatAppearance.MouseOverBackColor =
                PrimaryHoverColor;

            button.Font =
                HeaderFont;

            button.Cursor =
                Cursors.Hand;
        }

        public static void StyleDangerButton(
            Button button)
        {
            button.BackColor =
                DangerColor;

            button.ForeColor =
                Color.White;

            button.FlatStyle =
                FlatStyle.Flat;

            button.FlatAppearance.BorderSize = 0;

            button.FlatAppearance.MouseOverBackColor =
                DangerHoverColor;

            button.Font =
                HeaderFont;

            button.Cursor =
                Cursors.Hand;
        }

        public static void StyleSecondaryButton(
            Button button)
        {
            button.BackColor =
                SurfaceColor;

            button.ForeColor =
                TextDark;

            button.FlatStyle =
                FlatStyle.Flat;

            button.FlatAppearance.BorderColor =
                BorderColor;

            button.FlatAppearance.BorderSize = 1;

            button.Font =
                HeaderFont;

            button.Cursor =
                Cursors.Hand;
        }

        // =====================================================
        // TEXTBOX
        // =====================================================

        public static void StyleTextBox(
            TextBox textBox)
        {
            textBox.BackColor =
                SurfaceColor;

            textBox.ForeColor =
                TextDark;

            textBox.BorderStyle =
                BorderStyle.FixedSingle;

            textBox.Font =
                NormalFont;
        }

        // =====================================================
        // COMBOBOX
        // =====================================================

        public static void StyleComboBox(
            ComboBox comboBox)
        {
            comboBox.BackColor =
                SurfaceColor;

            comboBox.ForeColor =
                TextDark;

            comboBox.Font =
                NormalFont;

            comboBox.FlatStyle =
                FlatStyle.Flat;
        }

        // =====================================================
        // NUMERIC
        // =====================================================

        public static void StyleNumeric(
            NumericUpDown numeric)
        {
            numeric.Font =
                NormalFont;

            numeric.BackColor =
                SurfaceColor;

            numeric.ForeColor =
                TextDark;
        }

        // =====================================================
        // CHECKBOX
        // =====================================================

        public static void StyleCheckBox(
            CheckBox checkBox)
        {
            checkBox.Font =
                NormalFont;

            checkBox.ForeColor =
                TextDark;
        }

        // =====================================================
        // DATAGRIDVIEW
        // =====================================================

        public static void StyleGrid(
            DataGridView grid)
        {
            grid.BackgroundColor =
                SurfaceColor;

            grid.BorderStyle =
                BorderStyle.None;

            grid.GridColor =
                BorderColor;

            grid.RowHeadersVisible =
                false;

            grid.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            grid.EnableHeadersVisualStyles =
                false;

            grid.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            grid.ColumnHeadersHeight = 45;

            grid.RowTemplate.Height = 40;

            // HEADER

            grid.ColumnHeadersDefaultCellStyle
                .BackColor =
                    SurfaceColor;

            grid.ColumnHeadersDefaultCellStyle
                .ForeColor =
                    TextGray;

            grid.ColumnHeadersDefaultCellStyle
                .Font =
                    HeaderFont;

            grid.ColumnHeadersDefaultCellStyle
                .SelectionBackColor =
                    SurfaceColor;

            grid.ColumnHeadersDefaultCellStyle
                .SelectionForeColor =
                    TextGray;

            // CELLS

            grid.DefaultCellStyle.BackColor =
                SurfaceColor;

            grid.DefaultCellStyle.ForeColor =
                TextDark;

            grid.DefaultCellStyle.Font =
                NormalFont;

            grid.DefaultCellStyle.SelectionBackColor =
                SelectedRowColor;

            grid.DefaultCellStyle.SelectionForeColor =
                TextDark;

            grid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            grid.MultiSelect = false;

            grid.AllowUserToAddRows = false;

            grid.AllowUserToDeleteRows = false;

            grid.ReadOnly = true;
        }

        // =====================================================
        // TAB CONTROL
        // =====================================================

        public static void StyleTabControl(
            TabControl tab)
        {
            tab.Font =
                HeaderFont;
        }

        // =====================================================
        // SEARCH BOX PANEL
        // =====================================================

        public static void StyleSearchPanel(
            Panel panel)
        {
            panel.BackColor =
                SurfaceColor;

            panel.BorderStyle =
                BorderStyle.FixedSingle;
        }
    }
}