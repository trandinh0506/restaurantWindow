using System;
using System.Windows.Forms;

public class BookingDialog : Form
{
    public event EventHandler BookingForNowClicked;
    public event EventHandler BookingForLaterClicked;

    public BookingDialog()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        // Set up the form properties and controls
        Text = "Booking Options";
        Size = new System.Drawing.Size(300, 165);
        FormBorderStyle = FormBorderStyle.FixedDialog; // Set the form to be unresizable

        Label label = new Label
        {
            
            Dock = DockStyle.Top,
            Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))
        };

        Button nowButton = new Button
        {
            Text = "Booking for now",
            DialogResult = DialogResult.OK,
            Location = new System.Drawing.Point(0, 25),
            Size = new System.Drawing.Size(285, 50),
            Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))
        };

        Button laterButton = new Button
        {
            Text = "Booking for later",
            DialogResult = DialogResult.Yes,
            Location = new System.Drawing.Point(0, 75),
            Size = new System.Drawing.Size(285, 50),
            Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))
        };

        // Set up the event handlers for the buttons
        nowButton.Click += (sender, e) =>
        {
            BookingForNowClicked?.Invoke(this, EventArgs.Empty);
            Close();
        };

        laterButton.Click += (sender, e) =>
        {
            BookingForLaterClicked?.Invoke(this, EventArgs.Empty);
            Close();
        };

        Controls.Add(label);
        Controls.Add(nowButton);
        Controls.Add(laterButton);
    }

    public static DialogResult ShowBookingDialog(string message, Form mainForm)
    {
        using (BookingDialog bookingDialog = new BookingDialog())
        {
            bookingDialog.StartPosition = FormStartPosition.CenterParent;
            bookingDialog.Owner = mainForm; // Set the main form as the owner
            bookingDialog.Controls[0].Text = message;
            DialogResult result = bookingDialog.ShowDialog();

            // Return the appropriate result
            return result;
        }
    }
}
