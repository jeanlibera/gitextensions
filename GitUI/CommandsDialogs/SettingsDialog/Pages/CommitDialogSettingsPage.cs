﻿using GitCommands;

namespace GitUI.CommandsDialogs.SettingsDialog.Pages
{
    public partial class CommitDialogSettingsPage : SettingsPageWithHeader
    {
        public CommitDialogSettingsPage()
        {
            InitializeComponent();
            Text = "Commit dialog";
            Translate();
        }

        protected override void SettingsToPage()
        {
            chkShowErrorsWhenStagingFiles.Checked = AppSettings.ShowErrorsWhenStagingFiles;
            chkWriteCommitMessageInCommitWindow.Checked = AppSettings.UseFormCommitMessage;
            _NO_TRANSLATE_CommitDialogNumberOfPreviousMessages.Value = AppSettings.CommitDialogNumberOfPreviousMessages;
            chkCommitDlgShowAdvancedArea.Checked = AppSettings.CommitDlgShowAdvancedArea;
        }

        protected override void PageToSettings()
        {
            AppSettings.ShowErrorsWhenStagingFiles = chkShowErrorsWhenStagingFiles.Checked;
            AppSettings.UseFormCommitMessage = chkWriteCommitMessageInCommitWindow.Checked;
            AppSettings.CommitDialogNumberOfPreviousMessages = (int) _NO_TRANSLATE_CommitDialogNumberOfPreviousMessages.Value;
            AppSettings.CommitDlgShowAdvancedArea = chkCommitDlgShowAdvancedArea.Checked;
        }
    }
}
