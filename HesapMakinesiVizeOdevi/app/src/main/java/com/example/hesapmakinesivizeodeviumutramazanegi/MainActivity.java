package com.example.hesapmakinesivizeodeviumutramazanegi;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {
    String oldNumber="";
    String op = "+";
    boolean isNewOP=true;
    EditText ed1;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ed1= findViewById(R.id.editText);
    }

    public void numaraTik(View view) {
        if (isNewOP)
            ed1.setText("");
        isNewOP=false;
        String numara =ed1.getText().toString();
        switch (view.getId()){
            case R.id.bu1:
                numara +="1";
                break;
            case R.id.bu2:
                numara +="2";
                break;
            case R.id.bu3:
                numara +="3";
                break;
            case R.id.bu4:
                numara +="4";
                break;
            case R.id.bu5:
                numara +="5";
                break;
            case R.id.bu6:
                numara +="6";
                break;
            case R.id.bu7:
                numara +="7";
                break;
            case R.id.bu8:
                numara +="8";
                break;
            case R.id.bu9:
                numara +="9";
                break;
            case R.id.bu0:
                numara +="0";
                break;
            case R.id.bunokta:
                numara +=".";
                break;
            case R.id.buartieksi:
                numara ="-"+numara;
                break;

        }
        ed1.setText(numara);
    }

    public void operatorEvent(View view) {
        isNewOP =true;
        oldNumber=ed1.getText().toString();
        switch (view.getId()){
            case R.id.buBol: op ="/"; break;
            case R.id.buCarp: op ="*"; break;
            case R.id.buTopla: op ="+"; break;
            case R.id.buEksi: op ="-"; break;

        }

    }

    public void esittirEvent(View view) {
        String newNumber =ed1.getText().toString();
        double result = 0.0;
        switch (op){
            case "+":
                result =Double.parseDouble(oldNumber) + Double.parseDouble(newNumber);
                break;
            case "-":
                result =Double.parseDouble(oldNumber) - Double.parseDouble(newNumber);
                break;
            case "*":
                result =Double.parseDouble(oldNumber) * Double.parseDouble(newNumber);
                break;
            case "/":
                result =Double.parseDouble(oldNumber) / Double.parseDouble(newNumber);
                break;
        }
        ed1.setText(result+"");
    }

    public void silEvent(View view) {
        ed1.setText("0");
        isNewOP=true;
    }

    public void yuzdeEvent(View view) {
        double hayir =Double.parseDouble(ed1.getText().toString())/100;
        ed1.setText(hayir+"");
        isNewOP=true;
    }


}