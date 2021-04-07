package com.example.mycalculator;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Button increment = (Button) findViewById(R.id.incButton);
        increment.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                TextView textValue = (TextView) findViewById(R.id.textView);
                int number = Integer.parseInt(textValue.getText().toString());
                number++;
                textValue.setText(Integer.toString(number));
            }
        });
        Button decrement = (Button) findViewById(R.id.decButton);
        decrement.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                TextView textValue = (TextView) findViewById(R.id.textView);
                int number = Integer.parseInt(textValue.getText().toString());
                number--;
                textValue.setText(Integer.toString(number));
            }
        });
        TextView textView = (TextView) findViewById(R.id.textView);
        textView.setText("0");
        Button exit = (Button) findViewById(R.id.exitButton);
        exit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
    }

    @Override
    protected void onRestoreInstanceState(@NonNull Bundle savedInstanceState) {
        super.onRestoreInstanceState(savedInstanceState);
        TextView textView = (TextView) findViewById(R.id.textView);
        textView.setText(savedInstanceState.get("textView").toString());
    }

    @Override
    protected void onSaveInstanceState(Bundle outState) {
        TextView textView = (TextView) findViewById(R.id.textView);
        outState.putString("textView", textView.getText().toString());
        super.onSaveInstanceState(outState);
    }
}