#pragma once
#include"music.h"

namespace MusicApp {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Player
	/// </summary>
	public ref class Player : public System::Windows::Forms::Form
	{
	public:
		Player(void)
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
		~Player()
		{
			if (components)
			{
				delete components;
			}
		}
	//define the form components and names
	private: System::Windows::Forms::Button^  playButton;
	private: System::Windows::Forms::Label^  songTitle;
	private: System::Windows::Forms::PictureBox^  SongImage;
	protected:

	protected:

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
			int width = 400;
			int height = 600;
			int numS = 4; //number of songs
			music songs[4]; //array of music objects
			

			this->playButton = (gcnew System::Windows::Forms::Button());
			this->songTitle = (gcnew System::Windows::Forms::Label());
			this->SongImage = (gcnew System::Windows::Forms::PictureBox());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->SongImage))->BeginInit();
			this->SuspendLayout();

			// 
			// playButton
			// 
			this->playButton->Location = System::Drawing::Point(168, 420);
			this->playButton->Name = L"playButton";
			this->playButton->Size = System::Drawing::Size(75, 23);
			this->playButton->TabIndex = 1;
			this->playButton->Text = L"Play";
			this->playButton->UseVisualStyleBackColor = true;
			// 
			// songTitle
			// 
			this->songTitle->AutoSize = true;
			this->songTitle->Location = System::Drawing::Point(88, 325);
			this->songTitle->Name = L"songTitle";
			this->songTitle->Size = System::Drawing::Size(35, 17);
			this->songTitle->TabIndex = 2;
			this->songTitle->Text = L"Title";
			// 
			// SongImage
			// 
			this->SongImage->Location = System::Drawing::Point(81, 30);
			this->SongImage->Name = L"SongImage";
			this->SongImage->Size = System::Drawing::Size(220, 220);
			this->SongImage->TabIndex = 0;
			this->SongImage->TabStop = false;
			// 
			// Player
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(400, 600);
			this->Controls->Add(this->songTitle);
			this->Controls->Add(this->playButton);
			this->Controls->Add(this->SongImage);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::FixedSingle; //prevents user from scaling window
			this->Name = L"Player";
			this->Text = L"Music Player";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->SongImage))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	};
}
