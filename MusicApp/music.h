#pragma once
#include<iostream>
#include<string>

using namespace std;
using namespace System;

class music {
public:
	string sName;
	string sArtist; //song artist
	string sPic; //directory of picture
	int dur; //duration of song in seconds
};

void chgSong(Windows::Forms::Label^ nameLabel, Windows::Forms::Label^ artistLabel, music song) {
	String^ name = gcnew String(song.sName.c_str()); //converts to proper string type
	String^ artist = gcnew String(song.sArtist.c_str());
	nameLabel->Text = name;
	artistLabel->Text = artist;
};
