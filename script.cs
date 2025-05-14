const questions = [
  {
    question: "Who is the founder of modern debating?",
    answer: "Aristotle"
  },
  {
    question: "Which format uses POIs and 4 teams?",
    answer: "British Parliamentary"
  },
  {
    question: "What does 'motion' refer to in debate?",
    answer: "Debate topic"
  },
  {
    question: "FINAL PUZZLE: Rearrange 'ILENTNIOASG'",
    answer: "Legislation"
  }
];

let current = 0;

function loadQuestion() {
  if (current < questions.length) {
    document.getElementById("question").innerText = questions[current].question;
    document.getElementById("answerInput").value = "";
    document.getElementById("feedback").innerText = "";
  } else {
    document.getElementById("question-box").innerHTML = "<h2>🎉 Congratulations! You solved the final puzzle!</h2>";
  }
}

function checkAnswer() {
  const input = document.getElementById("answerInput").value.trim().toLowerCase();
  const correct = questions[current].answer.trim().toLowerCase();

  if (input === correct) {
    current++;
    loadQuestion();
  } else {
    document.getElementById("feedback").innerText = "❌ Try again!";
  }
}

window.onload = loadQuestion;
