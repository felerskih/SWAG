#pragma once

namespace CppWinForm1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for ManagerForm
	/// </summary>
	public ref class ManagerForm : public System::Windows::Forms::Form
	{
	public:
		ManagerForm(void)
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
		~ManagerForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Form ^ otherform;
	private: System::Windows::Forms::Button^  btnLogOut;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::ComboBox^  comboBox1;
	private: System::Windows::Forms::TextBox^  txtViewM;

	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::ComboBox^  comboBox2;
	private: System::Windows::Forms::TextBox^  txtSendM;

	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::ComboBox^  comboBox3;
	private: System::Windows::Forms::Button^  button2;
	private: System::Windows::Forms::ListBox^  listBox1;
	private: System::Windows::Forms::Button^  button3;
	private: System::Windows::Forms::ComboBox^  comboBox4;
	private: System::Windows::Forms::ListBox^  listBox2;

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
			this->btnLogOut = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->comboBox1 = (gcnew System::Windows::Forms::ComboBox());
			this->txtViewM = (gcnew System::Windows::Forms::TextBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->comboBox2 = (gcnew System::Windows::Forms::ComboBox());
			this->txtSendM = (gcnew System::Windows::Forms::TextBox());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->comboBox3 = (gcnew System::Windows::Forms::ComboBox());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->listBox1 = (gcnew System::Windows::Forms::ListBox());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->comboBox4 = (gcnew System::Windows::Forms::ComboBox());
			this->listBox2 = (gcnew System::Windows::Forms::ListBox());
			this->SuspendLayout();
			// 
			// btnLogOut
			// 
			this->btnLogOut->Location = System::Drawing::Point(500, 28);
			this->btnLogOut->Name = L"btnLogOut";
			this->btnLogOut->Size = System::Drawing::Size(75, 23);
			this->btnLogOut->TabIndex = 7;
			this->btnLogOut->Text = L"Log Out";
			this->btnLogOut->UseVisualStyleBackColor = true;
			this->btnLogOut->Click += gcnew System::EventHandler(this, &ManagerForm::btnLogOut_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(13, 28);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(35, 13);
			this->label1->TabIndex = 8;
			this->label1->Text = L"label1";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(328, 67);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(55, 13);
			this->label2->TabIndex = 9;
			this->label2->Text = L"Messages";
			// 
			// comboBox1
			// 
			this->comboBox1->DropDownStyle = System::Windows::Forms::ComboBoxStyle::DropDownList;
			this->comboBox1->FormattingEnabled = true;
			this->comboBox1->Location = System::Drawing::Point(331, 83);
			this->comboBox1->Name = L"comboBox1";
			this->comboBox1->Size = System::Drawing::Size(121, 21);
			this->comboBox1->TabIndex = 10;
			this->comboBox1->SelectedIndexChanged += gcnew System::EventHandler(this, &ManagerForm::comboBox1_SelectedIndexChanged);
			// 
			// txtViewM
			// 
			this->txtViewM->BackColor = System::Drawing::SystemColors::Window;
			this->txtViewM->Location = System::Drawing::Point(331, 111);
			this->txtViewM->Multiline = true;
			this->txtViewM->Name = L"txtViewM";
			this->txtViewM->ReadOnly = true;
			this->txtViewM->Size = System::Drawing::Size(244, 119);
			this->txtViewM->TabIndex = 11;
			this->txtViewM->Visible = false;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(331, 237);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(78, 13);
			this->label3->TabIndex = 12;
			this->label3->Text = L"Send Message";
			// 
			// comboBox2
			// 
			this->comboBox2->DropDownStyle = System::Windows::Forms::ComboBoxStyle::DropDownList;
			this->comboBox2->FormattingEnabled = true;
			this->comboBox2->Location = System::Drawing::Point(331, 262);
			this->comboBox2->Name = L"comboBox2";
			this->comboBox2->Size = System::Drawing::Size(121, 21);
			this->comboBox2->TabIndex = 13;
			// 
			// txtSendM
			// 
			this->txtSendM->Location = System::Drawing::Point(331, 302);
			this->txtSendM->Multiline = true;
			this->txtSendM->Name = L"txtSendM";
			this->txtSendM->Size = System::Drawing::Size(244, 62);
			this->txtSendM->TabIndex = 14;
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(331, 370);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(121, 23);
			this->button1->TabIndex = 15;
			this->button1->Text = L"button1";
			this->button1->UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(16, 284);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(69, 13);
			this->label4->TabIndex = 16;
			this->label4->Text = L"Flag Gambler";
			// 
			// comboBox3
			// 
			this->comboBox3->DropDownStyle = System::Windows::Forms::ComboBoxStyle::DropDownList;
			this->comboBox3->FormattingEnabled = true;
			this->comboBox3->Location = System::Drawing::Point(12, 311);
			this->comboBox3->Name = L"comboBox3";
			this->comboBox3->Size = System::Drawing::Size(128, 21);
			this->comboBox3->TabIndex = 17;
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(12, 340);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(128, 23);
			this->button2->TabIndex = 18;
			this->button2->Text = L"Flag Gambler";
			this->button2->UseVisualStyleBackColor = true;
			// 
			// listBox1
			// 
			this->listBox1->FormattingEnabled = true;
			this->listBox1->Location = System::Drawing::Point(148, 284);
			this->listBox1->Name = L"listBox1";
			this->listBox1->Size = System::Drawing::Size(155, 121);
			this->listBox1->TabIndex = 19;
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(12, 370);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(128, 23);
			this->button3->TabIndex = 20;
			this->button3->Text = L"View Flagged";
			this->button3->UseVisualStyleBackColor = true;
			// 
			// comboBox4
			// 
			this->comboBox4->DropDownStyle = System::Windows::Forms::ComboBoxStyle::DropDownList;
			this->comboBox4->FormattingEnabled = true;
			this->comboBox4->Location = System::Drawing::Point(16, 58);
			this->comboBox4->Name = L"comboBox4";
			this->comboBox4->Size = System::Drawing::Size(121, 21);
			this->comboBox4->TabIndex = 21;
			// 
			// listBox2
			// 
			this->listBox2->FormattingEnabled = true;
			this->listBox2->Location = System::Drawing::Point(16, 94);
			this->listBox2->Name = L"listBox2";
			this->listBox2->Size = System::Drawing::Size(121, 134);
			this->listBox2->TabIndex = 22;
			// 
			// ManagerForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(612, 422);
			this->Controls->Add(this->listBox2);
			this->Controls->Add(this->comboBox4);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->listBox1);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->comboBox3);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->txtSendM);
			this->Controls->Add(this->comboBox2);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->txtViewM);
			this->Controls->Add(this->comboBox1);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->btnLogOut);
			this->Name = L"ManagerForm";
			this->Text = L"ManagerForm";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
	public: ManagerForm(System::Windows::Forms::Form ^ frm1)
	{
		otherform = frm1;
		InitializeComponent();
	}
#pragma endregion
	private: System::Void btnLogOut_Click(System::Object^  sender, System::EventArgs^  e) {
		this->Hide();
		otherform->Show();
	}
	private: System::Void comboBox1_SelectedIndexChanged(System::Object^  sender, System::EventArgs^  e) 
	{
		
	}
};
}
