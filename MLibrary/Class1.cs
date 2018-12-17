using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLibrary
{
    public class Class1
    {
        // Instanciando ChromeDriver para ser usado
        ChromeDriver driver = new ChromeDriver();
        // Modo Headless , serve pra automatizar sem abrir o navegador 
        public void Headless()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("headless");
            // Deixar configuraçao igual caso for usa em maquinas diferentes
            options.AddArguments("window-size=1200x600");
        }
        // ScreenShoot Sem data/hora , normalmente nao serve para nada em um projeto.
        public void Sshoot()
        {
            Screenshot file = ((ITakesScreenshot)driver).GetScreenshot();
            file.SaveAsFile(@"C:\Users\ma20044294\Desktop\image.Png", OpenQA.Selenium.ScreenshotImageFormat.Png);
        }
        // Instancia a classe IJavaScriptExecutor para usar os comandos do scrool
        public void Scrool()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,4000);");
        }
        // Deleta todos os cookies para deixar o ambiente preparado para o proximo teste
        public void Deletecok()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }
        // Coloca uma espera no teste caso estiver fazendo muito rapido
        public void WaitingTime()
        {
            System.Threading.Thread.Sleep(2000);
        }
        // Dá um mouse over em cima do elemento escolhido ( necessario importar classe Actions ) 
        public void mouseOver()
        {
            action.MoveToElement(driver.FindElement(pagina.compreDepartamento)).Perform();
        }
        // Validaçao de um elemento usando o IF, ( pagina é o objeto criado para nao procurar na pagina inteira
        //public void validarIf()
        //{
        //    if (pagina.label.Equals("árvores de natal"))
        //    {
        //        Console.Write("Rolou!!");
        //    }
        //    else
        //    {
        //        Console.Write("Nao rolou!!");
        //    }
        //}

            // Padrão ÁGORA de pegar objetos
        public void pegandoObjetos()
        {
                    //public By compreDepartamento { get { return By.ClassName("mmn-sdb-title"); } }
        }
        // Finalizando os processos e os passos pós teste
        public void Finalizar()
        {
            driver.Quit();
            driver = null;
        }
        public void UsandoComboBox()
        {
            //IWebElement course = m_driver.FindElement(By.XPath(".//*[@id='awf_field-91977689']"));
            //var selectTest = new SelectElement(course);           			
            //selectTest.SelectByValue("sap-abap");
        }


    }
}
