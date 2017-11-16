#pragma once

namespace CppWinForm1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for RegisterUser
	/// </summary>
	public ref class RegisterUser : public System::Windows::Forms::Form
	{
	public:
		RegisterUser(void)
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
		~RegisterUser()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^  txtUserN;
	protected:

	private: System::Windows::Forms::TextBox^  txtPassW;
	protected:


	protected:

	private: System::Windows::Forms::Label^  lblUserN;
	private: System::Windows::Forms::Label^  lblPassW;
	private: System::Windows::Forms::Label^  lblNewUser;
	private: System::Windows::Forms::Label^  lblNewPass;
	private: System::Windows::Forms::Button^  btnRegis;
	private: System::Windows::Forms::Button^  btnCancel;



	private: System::Windows::Forms::Form ^ otherform;

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
			this->txtUserN = (gcnew System::Windows::Forms::TextBox());
			this->txtPassW = (gcnew System::Windows::Forms::TextBox());
			this->lblUserN = (gcnew System::Windows::Forms::Label());
			this->lblPassW = (gcnew System::Windows::Forms::Label());
			this->lblNewUser = (gcnew System::Windows::Forms::Label());
			this->lblNewPass = (gcnew System::Windows::Forms::Label());
			this->btnRegis = (gcnew System::Windows::Forms::Button());
			this->btnCancel = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// txtUserN
			// 
			this->txtUserN->Location = System::Drawing::Point(142, 39);
			this->txtUserN->Name = L"txtUserN";
			this->txtUserN->Size = System::Drawing::Size(227, 20);
			this->txtUserN->TabIndex = 0;
			// 
			// txtPassW
			// 
			this->txtPassW->Location = System::Drawing::Point(142, 86);
			this->txtPassW->Name = L"txtPassW";
			this->txtPassW->Size = System::Drawing::Size(227, 20);
			this->txtPassW->TabIndex = 1;
			// 
			// lblUserN
			// 
			this->lblUserN->AutoSize = true;
			this->lblUserN->Location = System::Drawing::Point(376, 45);
			this->lblUserN->Name = L"lblUserN";
			this->lblUserN->Size = System::Drawing::Size(30, 13);
			this->lblUserN->TabIndex = 2;
			this->lblUserN->Text = L"Valid";
			// 
			// lblPassW
			// 
			this->lblPassW->AutoSize = true;
			this->lblPassW->Location = System::Drawing::Point(376, 92);
			this->lblPassW->Name = L"lblPassW";
			this->lblPassW->Size = System::Drawing::Size(30, 13);
			this->lblPassW->TabIndex = 3;
			this->lblPassW->Text = L"Valid";
			// 
			// lblNewUser
			// 
			this->lblNewUser->AutoSize = true;
			this->lblNewUser->Location = System::Drawing::Point(55, 42);
			this->lblNewUser->Name = L"lblNewUser";
			this->lblNewUser->Size = System::Drawing::Size(83, 13);
			this->lblNewUser->TabIndex = 4;
			this->lblNewUser->Text = L"New Username:";
			// 
			// lblNewPass
			// 
			this->lblNewPass->AutoSize = true;
			this->lblNewPass->Location = System::Drawing::Point(55, 89);
			this->lblNewPass->Name = L"lblNewPass";
			this->lblNewPass->Size = System::Drawing::Size(81, 13);
			this->lblNewPass->TabIndex = 5;
			this->lblNewPass->Text = L"New Password:";
			// 
			// btnRegis
			// 
			this->btnRegis->Location = System::Drawing::Point(142, 128);
			this->btnRegis->Name = L"btnRegis";
			this->btnRegis->Size = System::Drawing::Size(75, 23);
			this->btnRegis->TabIndex = 6;
			this->btnRegis->Text = L"Register!";
			this->btnRegis->UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this->btnCancel->Location = System::Drawing::Point(253, 128);
			this->btnCancel->Name = L"btnCancel";
			this->btnCancel->Size = System::Drawing::Size(75, 23);
			this->btnCancel->TabIndex = 8;
			this->btnCancel->Text = L"Cancel";
			this->btnCancel->UseVisualStyleBackColor = true;
			this->btnCancel->Click += gcnew System::EventHandler(this, &RegisterUser::btnCancel_Click);
			// 
			// RegisterUser
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(510, 211);
			this->Controls->Add(this->btnCancel);
			this->Controls->Add(this->btnRegis);
			this->Controls->Add(this->lblNewPass);
			this->Controls->Add(this->lblNewUser);
			this->Controls->Add(this->lblPassW);
			this->Controls->Add(this->lblUserN);
			this->Controls->Add(this->txtPassW);
			this->Controls->Add(this->txtUserN);
			this->Name = L"RegisterUser";
			this->Text = L"RegisterUser";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
		public: RegisterUser(System::Windows::Forms::Form ^ frm1)
		{
			otherform = frm1;
			InitializeComponent();
		}
#pragma endregion
	private: System::Void btnCancel_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		this->Hide();
		otherform->Show();
	}
};
}
