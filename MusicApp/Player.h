#pragma once
#include"music.h"

const int numSongs = 4;
int curSong = -1;
music songs[numSongs]; //array of music objects


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
	private: System::Windows::Forms::Button^  nextButton;
	private: System::Windows::Forms::Button^  prevButton;
	private: System::Windows::Forms::Button^  playButton;
	private: System::Windows::Forms::Label^  songTitle;
	private: System::Windows::Forms::Label^  songArtist;
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
			// ------------------------------------------------------------------------------
			int width = 400;
			int height = 600;
			int numS = 4; //number of songs

			songs[0].sName = "Selling Flowers";
			songs[0].sArtist = "Slow Hollows";
			songs[1].sName = "Everything Now";
			songs[1].sArtist = "Arcade Fire";
			songs[2].sName = "Shiver";
			songs[2].sArtist = "Lucy Rose";
			songs[3].sName = "Bloom";
			songs[3].sArtist = "Paper Kites";

			// ------------------------------------------------------------------------------
			this->nextButton = (gcnew System::Windows::Forms::Button());
			this->prevButton = (gcnew System::Windows::Forms::Button());
			this->playButton = (gcnew System::Windows::Forms::Button());
			this->songTitle = (gcnew System::Windows::Forms::Label());
			this->songArtist = (gcnew System::Windows::Forms::Label());
			this->SongImage = (gcnew System::Windows::Forms::PictureBox());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->SongImage))->BeginInit();
			this->SuspendLayout();

			// 
			// nextButton
			//
			int pbSize = 50;
			this->nextButton->Anchor = static_cast<System::Windows::Forms::AnchorStyles>((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Right));
			this->nextButton->Location = System::Drawing::Point(3*width/4 -pbSize/2, 3 * height / 4);
			this->nextButton->Name = L"nextButton";
			this->nextButton->Size = System::Drawing::Size(pbSize, pbSize);
			this->nextButton->TabIndex = 1;
			this->nextButton->Text = L" >> ";
			this->nextButton->UseVisualStyleBackColor = true;
			this->nextButton->Click += gcnew System::EventHandler(this, &Player::nextClick);
			// 
			// prevButton
			//
			this->prevButton->Anchor = static_cast<System::Windows::Forms::AnchorStyles>((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Right));
			this->prevButton->Location = System::Drawing::Point(width/4 - pbSize/2, 3 * height / 4);
			this->prevButton->Name = L"prevButton";
			this->prevButton->Size = System::Drawing::Size(pbSize, pbSize);
			this->prevButton->TabIndex = 1;
			this->prevButton->Text = L" << ";
			this->prevButton->UseVisualStyleBackColor = true;
			this->prevButton->Click += gcnew System::EventHandler(this, &Player::prevClick);
			this->prevButton->Enabled = false;
			// 
			// playButton
			//
			this->playButton->Anchor = static_cast<System::Windows::Forms::AnchorStyles>((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Right));
			this->playButton->Location = System::Drawing::Point((width - pbSize) / 2, 3 * height / 4);
			this->playButton->Name = L"playButton";
			this->playButton->Size = System::Drawing::Size(pbSize, pbSize);
			this->playButton->TabIndex = 1;
			this->playButton->Text = L" || ";
			this->playButton->UseVisualStyleBackColor = true;
			this->playButton->Click += gcnew System::EventHandler(this, &Player::playClick);
			// 
			// songTitle
			// 
			this->songTitle->Location = System::Drawing::Point(0, height / 2); //position
			this->songTitle->Name = L"songTitle";
			this->songTitle->Size = System::Drawing::Size(width, 20); //make entire width of form to centre properly
			this->songTitle->TabIndex = 2;
			this->songTitle->Text = L"Title goes here I suppose";
			this->songTitle->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			// 
			// songArtist
			// 
			this->songArtist->Location = System::Drawing::Point(0, height / 2 + 30); //position
			this->songArtist->Name = L"songArtist";
			this->songArtist->Size = System::Drawing::Size(width, 20); //make entire width of form to centre properly
			this->songArtist->TabIndex = 2;
			this->songArtist->Text = L"Artist goes here I suppose";
			this->songArtist->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
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
			this->ClientSize = System::Drawing::Size(width, height);
			this->Controls->Add(this->songTitle);
			this->Controls->Add(this->songArtist);
			this->Controls->Add(this->nextButton);
			this->Controls->Add(this->prevButton);
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
	private: System::Void nextClick(System::Object^  sender, System::EventArgs^  e) {
		curSong++;
		chgSong(songTitle, songArtist, songs[curSong]);
		if(curSong > 0)
			prevButton->Enabled = true;
		if (curSong >= numSongs - 1) {
			nextButton->Enabled = false;
			return;
		}
	}
	private: System::Void prevClick(System::Object^  sender, System::EventArgs^  e) {
		curSong--;
		if (curSong == 0)
			prevButton->Enabled = false;
		chgSong(songTitle, songArtist, songs[curSong]);
		nextButton->Enabled = true;
	}
	private: System::Void playClick(System::Object^  sender, System::EventArgs^  e) {
		//
	}
	};
}
