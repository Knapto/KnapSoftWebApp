document.addEventListener("DOMContentLoaded", function () {
    const chatBtn = document.getElementById("chatButton");
    const chatBox = document.getElementById("chatBox");
    const closeBtn = document.getElementById("closeChat");
    const sendBtn = document.getElementById("sendMessage");
    const userInput = document.getElementById("userInput");
    const chatMessages = document.getElementById("chatMessages");

    if (chatBtn && chatBox && closeBtn && sendBtn && userInput && chatMessages) {
        chatBtn.addEventListener("click", () => {
            chatBox.style.display = "block";
        });

        closeBtn.addEventListener("click", () => {
            chatBox.style.display = "none";
        });

        sendBtn.addEventListener("click", async () => {
            const text = userInput.value.trim();
            if (!text) return;

            chatMessages.innerHTML += `<div><strong>Vy:</strong> ${text}</div>`;
            userInput.value = "";

            try {
                const response = await fetch("/api/chat", {
                    method: "POST",
                    headers: { "Content-Type": "application/json" },
                    body: JSON.stringify({ message: text })
                });

                const data = await response.json();
                chatMessages.innerHTML += `<div><strong>KnapBot:</strong> ${data.reply}</div>`;
                chatMessages.scrollTop = chatMessages.scrollHeight;
            } catch (error) {
                chatMessages.innerHTML += `<div class="text-danger"><strong>KnapBot:</strong> Došlo k chybě.</div>`;
            }
        });
    }
});