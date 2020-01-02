#pragma once
#include"music.h"

const int numSongs = 4;
int curSong = 0;
music songs[numSongs]; //array of music objects
bool playing = false;

namespace MusicApp {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for progtest
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
	private: System::Windows::Forms::ProgressBar^  progress;
	protected:
	private: System::ComponentModel::IContainer^  components;
	private: System::Windows::Forms::Button^  nextButton;
	private: System::Windows::Forms::Button^  prevButton;
	private: System::Windows::Forms::Button^  playButton;
	private: System::Windows::Forms::Label^  songTitle;
	private: System::Windows::Forms::Label^  songArtist;
	private: System::Windows::Forms::Timer^  timer;
	private: System::Windows::Forms::PictureBox^  SongImage;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>


#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			int width = 400;
			int height = 600;
			songs[0].sName = "Selling Flowers";
			songs[0].sArtist = "Slow Hollows";
			songs[0].dur = 10;
			songs[1].sName = "Everything Now";
			songs[1].sArtist = "Arcade Fire";
			songs[1].dur = 5;
			songs[2].sName = "Shiver";
			songs[2].sArtist = "Lucy Rose";
			songs[2].dur = 20;
			songs[3].sName = "Bloom";
			songs[3].sArtist = "Paper Kites";
			songs[3].dur = 10;

			this->components = (gcnew System::ComponentModel::Container());
			this->progress = (gcnew System::Windows::Forms::ProgressBar());
			this->nextButton = (gcnew System::Windows::Forms::Button());
			this->prevButton = (gcnew System::Windows::Forms::Button());
			this->playButton = (gcnew System::Windows::Forms::Button());
			this->songTitle = (gcnew System::Windows::Forms::Label());
			this->songArtist = (gcnew System::Windows::Forms::Label());
			this->SongImage = (gcnew System::Windows::Forms::PictureBox());
			this->timer = (gcnew System::Windows::Forms::Timer(this->components));
			this->SuspendLayout();
			// 
			// Progress 
			//
			int progSize = 300;
			this->progress->Location = System::Drawing::Point(width / 2 - progSize / 2, 3 * height / 4 - 60);
			this->progress->Name = L"progress";
			this->progress->Size = System::Drawing::Size(progSize, 20);
			this->progress->TabIndex = 0;
			// 
			// nextButton
			//
			int pbSize = 50;
			this->nextButton->Anchor = static_cast<System::Windows::Forms::AnchorStyles>((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Right));
			this->nextButton->Location = System::Drawing::Point(3 * width / 4 - pbSize / 2, 3 * height / 4);
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
			this->prevButton->Location = System::Drawing::Point(width / 4 - pbSize / 2, 3 * height / 4);
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
			this->playButton->Text = L" |> ";
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

			chgSong(songTitle, songArtist, progress, songs[curSong]);
			// 
			// SongImage
			//
			this->SongImage->Location = System::Drawing::Point(81, 30);
			this->SongImage->Name = L"SongImage";
			this->SongImage->Size = System::Drawing::Size(220, 220);
			this->SongImage->TabIndex = 0;
			this->SongImage->TabStop = false;
			// 
			// Timer
			// 
			this->timer->Tick += gcnew System::EventHandler(this, &Player::timer_Tick);
			this->timer->Interval = 1000; //set 1 second as the incrementation time
			// 
			// progtest
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
			this->Controls->Add(this->progress);
			this->Name = L"progtest";
			this->Text = L"progtest";
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void playClick(System::Object^  sender, System::EventArgs^  e) {
		if (playing) {
			this->timer->Stop();
			playing = false;
			playButton->Text = L" |> ";
		}
		else {
			this->timer->Start();
			playing = true;
			playButton->Text = L" | | ";
		}
	}
	private: System::Void nextClick(System::Object^  sender, System::EventArgs^  e) {
		curSong++; //position in queue
		chgSong(songTitle, songArtist, progress, songs[curSong]); //change song
		progress->Value = 0;
		if (curSong > 0)
			prevButton->Enabled = true;
		if (curSong >= numSongs - 1) {
			nextButton->Enabled = false;
			return;
		}
	}
	private: System::Void prevClick(System::Object^  sender, System::EventArgs^  e) {
		curSong--; //position in queue
		if (curSong == 0)
			prevButton->Enabled = false;
		chgSong(songTitle, songArtist, progress, songs[curSong]); //change song
		progress->Value = 0;
		nextButton->Enabled = true;
	}
	private: System::Void timer_Tick(System::Object^  sender, System::EventArgs^  e) {
		this->progress->Increment(1);
	}
	};
}
