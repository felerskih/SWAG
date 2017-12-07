#pragma once
#include "RegisterUser.h"
#include "GamblerForm.h"
#include "ManagerForm.h"
#include "DealerView.h"
#include <string>
#include <iostream>
#include <fstream>
#include <istream>
#include <map>
#include <set>
#include <msclr\marshal_cppstd.h> 
using namespace msclr::interop;
using namespace System::Runtime::InteropServices;
using namespace std;
namespace CppWinForm1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			this->Location.X = 500;
			this->Location.Y = 500;
			//
		}
	public: 
	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^  txtUser;
	protected:
		string * users = new string[100];
		string * pass = new string[100];
		int * typeUser = new int[100];
		int size = 0;
	private: System::Windows::Forms::TextBox^  txtPass;
	private: System::Windows::Forms::Button^  btnLogIn;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::PictureBox^  pictureBox1;
	private: System::Windows::Forms::Button^  btnRegister;
	private: System::Windows::Forms::OpenFileDialog^  openFileDialog1;

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
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(MyForm::typeid));
			this->txtUser = (gcnew System::Windows::Forms::TextBox());
			this->txtPass = (gcnew System::Windows::Forms::TextBox());
			this->btnLogIn = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			this->btnRegister = (gcnew System::Windows::Forms::Button());
			this->openFileDialog1 = (gcnew System::Windows::Forms::OpenFileDialog());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->BeginInit();
			this->SuspendLayout();
			// 
			// txtUser
			// 
			this->txtUser->Location = System::Drawing::Point(107, 68);
			this->txtUser->Name = L"txtUser";
			this->txtUser->Size = System::Drawing::Size(108, 20);
			this->txtUser->TabIndex = 0;
			// 
			// txtPass
			// 
			this->txtPass->Location = System::Drawing::Point(108, 104);
			this->txtPass->Name = L"txtPass";
			this->txtPass->PasswordChar = '*';
			this->txtPass->Size = System::Drawing::Size(107, 20);
			this->txtPass->TabIndex = 1;
			this->txtPass->UseSystemPasswordChar = true;
			// 
			// btnLogIn
			// 
			this->btnLogIn->Location = System::Drawing::Point(107, 158);
			this->btnLogIn->Name = L"btnLogIn";
			this->btnLogIn->Size = System::Drawing::Size(108, 20);
			this->btnLogIn->TabIndex = 2;
			this->btnLogIn->Text = L"Log In!";
			this->btnLogIn->UseVisualStyleBackColor = true;
			this->btnLogIn->Click += gcnew System::EventHandler(this, &MyForm::btnLogIn_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(34, 75);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(58, 13);
			this->label1->TabIndex = 3;
			this->label1->Text = L"Username:";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(36, 107);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(56, 13);
			this->label2->TabIndex = 4;
			this->label2->Text = L"Password:";
			// 
			// pictureBox1
			// 
			this->pictureBox1->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"pictureBox1.Image")));
			this->pictureBox1->Location = System::Drawing::Point(12, 195);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(268, 250);
			this->pictureBox1->TabIndex = 5;
			this->pictureBox1->TabStop = false;
			// 
			// btnRegister
			// 
			this->btnRegister->Location = System::Drawing::Point(107, 27);
			this->btnRegister->Name = L"btnRegister";
			this->btnRegister->Size = System::Drawing::Size(108, 23);
			this->btnRegister->TabIndex = 6;
			this->btnRegister->Text = L"Register";
			this->btnRegister->UseVisualStyleBackColor = true;
			this->btnRegister->Click += gcnew System::EventHandler(this, &MyForm::btnRegister_Click);
			// 
			// openFileDialog1
			// 
			this->openFileDialog1->FileName = L"C:\\Users\\gantenbeina\\Downloads\\test.txt";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(308, 462);
			this->Controls->Add(this->btnRegister);
			this->Controls->Add(this->pictureBox1);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->btnLogIn);
			this->Controls->Add(this->txtPass);
			this->Controls->Add(this->txtUser);
			this->Name = L"MyForm";
			this->Text = L"Log In: SWAG Systems";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void btnLogIn_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		int j = 0;
		while (marshal_as<string>(txtUser->Text) != users[j] && j < size)
			j++;
		if (marshal_as<string>(txtPass->Text) == pass[j])
		{
			int userType = typeUser[j];
			if (userType == 0)
			{
				ManagerForm ^ man = gcnew ManagerForm(this);
				this->Hide();
				man->Show();
			}
			else if (userType == 1)
			{
				DealerView ^ deal = gcnew DealerView(this);
				this->Hide();
				deal->Show();
			}
			else if (userType == 2)
			{
				GamblerForm ^ gam = gcnew GamblerForm(this);
				this->Hide();
				gam->Show();
			}
			else
				MessageBox::Show("Incorreassword");
		}
		else
		{
			MessageBox::Show("Incorrect Username/Password");
		}
		
	}
private: System::Void btnRegister_Click(System::Object^  sender, System::EventArgs^  e) 
{
	RegisterUser ^ regis = gcnew RegisterUser(this, users);
	this->Hide();
	regis->Show();

}
private: System::Void MyForm_Load(System::Object^  sender, System::EventArgs^  e) 
{
	string file = marshal_as<string>(openFileDialog1->FileName);
	fstream is;
	string u, p;
	is.open(file);
	try
	{
		while (is)
		{
			
			is >> users[size];
			is >> pass[size];
			is >> typeUser[size];
			size++;
		}
	}
	catch (...)
	{
		MessageBox::Show("Bad Input File!");
	}
	is.close();
}
};
}
