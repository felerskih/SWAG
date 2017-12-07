#pragma once

#include <string>
#include <iostream>
using namespace std;
namespace CppWinForm1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for GamblerForm
	/// </summary>
	public ref class GamblerForm : public System::Windows::Forms::Form
	{
	public:
		GamblerForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~GamblerForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Label^  lblFunds;
	protected:

	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::TextBox^  txtAddFund;
	private: System::Windows::Forms::TextBox^  txtWithdrawFund;


	private: System::Windows::Forms::Button^  btnLogOut;


	private: System::Windows::Forms::Form ^ otherform;
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::Button^  button2;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->lblFunds = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->txtAddFund = (gcnew System::Windows::Forms::TextBox());
			this->txtWithdrawFund = (gcnew System::Windows::Forms::TextBox());
			this->btnLogOut = (gcnew System::Windows::Forms::Button());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(59, 26);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(76, 13);
			this->label1->TabIndex = 0;
			this->label1->Text = L"Current Funds:";
			// 
			// lblFunds
			// 
			this->lblFunds->AutoSize = true;
			this->lblFunds->Location = System::Drawing::Point(169, 26);
			this->lblFunds->Name = L"lblFunds";
			this->lblFunds->Size = System::Drawing::Size(28, 13);
			this->lblFunds->TabIndex = 1;
			this->lblFunds->Text = L"0.00";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(59, 60);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(61, 13);
			this->label3->TabIndex = 2;
			this->label3->Text = L"Add Funds:";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(59, 101);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(87, 13);
			this->label4->TabIndex = 3;
			this->label4->Text = L"Withdraw Funds:";
			// 
			// txtAddFund
			// 
			this->txtAddFund->Location = System::Drawing::Point(172, 53);
			this->txtAddFund->Name = L"txtAddFund";
			this->txtAddFund->Size = System::Drawing::Size(100, 20);
			this->txtAddFund->TabIndex = 4;
			// 
			// txtWithdrawFund
			// 
			this->txtWithdrawFund->Location = System::Drawing::Point(172, 94);
			this->txtWithdrawFund->Name = L"txtWithdrawFund";
			this->txtWithdrawFund->Size = System::Drawing::Size(100, 20);
			this->txtWithdrawFund->TabIndex = 5;
			// 
			// btnLogOut
			// 
			this->btnLogOut->Location = System::Drawing::Point(161, 156);
			this->btnLogOut->Name = L"btnLogOut";
			this->btnLogOut->Size = System::Drawing::Size(75, 23);
			this->btnLogOut->TabIndex = 6;
			this->btnLogOut->Text = L"Log Out";
			this->btnLogOut->UseVisualStyleBackColor = true;
			this->btnLogOut->Click += gcnew System::EventHandler(this, &GamblerForm::btnLogOut_Click);
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(295, 53);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(99, 23);
			this->button1->TabIndex = 7;
			this->button1->Text = L"Add Funds!";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &GamblerForm::button1_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(295, 94);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(99, 23);
			this->button2->TabIndex = 8;
			this->button2->Text = L"Withdraw Funds!";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &GamblerForm::button2_Click);
			// 
			// GamblerForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(424, 239);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->btnLogOut);
			this->Controls->Add(this->txtWithdrawFund);
			this->Controls->Add(this->txtAddFund);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->lblFunds);
			this->Controls->Add(this->label1);
			this->Name = L"GamblerForm";
			this->Text = L"GamblerForm";
			this->ResumeLayout(false);
			this->PerformLayout();

		}

		public: GamblerForm(System::Windows::Forms::Form ^ frm1)
		{
			otherform = frm1;
			InitializeComponent();
		}
#pragma endregion

	private: System::Void btnLogOut_Click(System::Object^  sender, System::EventArgs^  e) {
		this->Hide();
		otherform->Show();
	}
private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) 
{
	try
	{
		double f = Convert::ToDouble(txtAddFund->Text);
		double g = Convert::ToDouble(lblFunds->Text);
		double result = f + g;
		//string dummy = result.ToString;
		lblFunds->Text = Convert::ToString(result);

	}
	catch (...)
	{
		MessageBox::Show("Please enter a real dollar amount!");
		txtAddFund->Clear();
	}

}
private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) 
{
	try
	{
		double f = Convert::ToDouble(txtWithdrawFund->Text);
		double g = Convert::ToDouble(lblFunds->Text);
		double result = g - f;
		//string dummy = result.ToString;
		lblFunds->Text = Convert::ToString(result);

	}
	catch (...)
	{
		MessageBox::Show("Please enter a real dollar amount!");
		txtAddFund->Clear();
	}
}
};
}
