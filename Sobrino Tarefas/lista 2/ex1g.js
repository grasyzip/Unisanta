const readline = require("readline");

function desafioSobrino() {
  const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
  });

  function mostrarLoading(texto, duracao = 2000) {
    return new Promise((resolve) => {
      const frames = ["⠋", "⠙", "⠹", "⠸", "⠼", "⠴", "⠦", "⠧", "⠇", "⠏"];
      let i = 0;

      const interval = setInterval(() => {
        process.stdout.write(`\r${frames[i]} ${texto}`);
        i = (i + 1) % frames.length;
      }, 100);

      setTimeout(() => {
        clearInterval(interval);
        process.stdout.write("✅ " + texto + " - CONCLUÍDO");
        resolve();
      }, duracao);
    });
  }

  async function iniciarDesafio() {
    console.log("INICIANDO SISTEMA DO SOBRINO...");

    console.log(" ");
    await mostrarLoading("Carregando módulos secretos", 1500);
    console.log(" ");
    await mostrarLoading("Decodificando DLC", 1800);
    console.log(" ");
    await mostrarLoading("Verificando credenciais", 1200);
    console.log(" ");

    console.log(" ");
    console.log("SISTEMA PRONTO!");
    console.log(" ");
    console.log(" ");
    rl.question(
      "Deseja desbloquear a DLC secreta? (S/N) ",
      async (resposta) => {
        const respostaUpper = resposta.toUpperCase().trim();

        if (respostaUpper === "S" || respostaUpper === "SIM") {
          console.log(" ");
          console.log("INICIANDO DESBLOQUEIO...");
          await mostrarLoading("Desbloqueando conteúdo secreto", 2000);
          console.log(" ");

          // Animação da dança
          console.log(" ");
          console.log("DANÇA DA VITÓRIA!");
          const dancas = [
            "♪┏(・o･)┛♪",
            "♪┗ ( ･o･) ┓♪",
            "╰(▔∀▔)╯",
            "♪┏(・o･)┛♪",
            "♪┗ ( ･o･) ┓♪",
          ];
          console.log(" ");
          let count = 0;

          const danceInterval = setInterval(() => {
            process.stdout.write("\r" + dancas[count % dancas.length] + " ");
            count++;
          }, 300);

          setTimeout(() => {
            clearInterval(danceInterval);
            console.log(" ");
            console.log("DLC DESBLOQUEADA!");
            console.log("🌟 +1000 XP");
            console.log(" ");
            rl.close();
          }, 3000);
        } else {
          console.log(" ");
          console.log("DLC NÃO DESBLOQUEADA...");
          console.log("(个_个) Sobrino está triste...");
          rl.close();
        }
      }
    );
  }

  iniciarDesafio();
}

desafioSobrino();
