package com.inhatc.startupproject;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Spinner month = (Spinner) findViewById(R.id.month);
        Spinner gender = (Spinner) findViewById(R.id.gender);

        ArrayAdapter<CharSequence> monthadapter = ArrayAdapter.createFromResource(this,
                R.array.my_montharray, android.R.layout.simple_spinner_item);

        ArrayAdapter<CharSequence> genderadapter = ArrayAdapter.createFromResource(this,
                R.array.my_genderarray, android.R.layout.simple_spinner_item);

        monthadapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        genderadapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);

        month.setAdapter(monthadapter);
        gender.setAdapter(genderadapter);
    }
}