package com.example.myapplication;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
    int likes = 0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        Button likeBtn = findViewById(R.id.likeBtn);
        Button deleteBtn = findViewById(R.id.deleteBtn);

        TextView likesTxt = findViewById(R.id.likes);

        likeBtn.setOnClickListener(v -> {
            likes++;
            likesTxt.setText(likes+" polubień");
        });
        deleteBtn.setOnClickListener(v -> {
            if(likes < 1) return;
            likes--;
            likesTxt.setText(likes+" polubień");
        });
    }
}