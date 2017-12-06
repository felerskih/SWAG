#pragma once

namespace CppWinForm1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for DealerView
	/// </summary>
	public ref class DealerView : public System::Windows::Forms::Form
	{
	public:
		DealerView(void)
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
		~DealerView()
		{
			if (components)
			{
				delete components;
			}
		}

	private: System::Windows::Forms::Form ^ otherform;
	private: System::Windows::Forms::Button^  btnLogOut;
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
			this->SuspendLayout();
			// 
			// btnLogOut
			// 
			this->btnLogOut->Location = System::Drawing::Point(105, 119);
			this->btnLogOut->Name = L"btnLogOut";
			this->btnLogOut->Size = System::Drawing::Size(75, 23);
			this->btnLogOut->TabIndex = 7;
			this->btnLogOut->Text = L"Log Out";
			this->btnLogOut->UseVisualStyleBackColor = true;
			this->btnLogOut->Click += gcnew System::EventHandler(this, &DealerView::btnLogOut_Click);
			// 
			// DealerView
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(284, 261);
			this->Controls->Add(this->btnLogOut);
			this->Name = L"DealerView";
			this->Text = L"DealerView";
			this->ResumeLayout(false);

		}
	public: DealerView(System::Windows::Forms::Form ^ frm1)
	{
		otherform = frm1;
		InitializeComponent();
	}
#pragma endregion
	private: System::Void btnLogOut_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		this->Hide();
		otherform->Show();
	}
	};
}
