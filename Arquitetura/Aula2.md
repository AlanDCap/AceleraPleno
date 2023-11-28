# Atividade

## Minha empresa de Energia

1 maior agilidade para identificar e tratar problemas na rede de distribuição
2 materiais e ferramentas são perdidos com frequência no campo
3 os sistemas da empresa são muito lentos
4 expandir alcance da área de cobertura
5 reduzir emissão de carbono

## Arquitetura de software no setor de saúde

### Nome da Empresa: Clínica PopHealth

Sou proprietária de uma clínica popular localizada em uma cidade de pequeno-médio porte no interior do Estado de Minas Gerais. Nossa clínica oferece consultas e exames com médicos especializados em diversas áreas da medicina, como cardiologia, dermatologia, endoicrinologia, geriatria, ginecologia, neurologia, nutrologia, otorrinolaringologia, pediatria, urologia, além de clínicos gerais, então atendemos pacientes de todas as idades e gêneros, por preços acessíveis para a população local.

Porém, com o crescimento explosivo que a cidade teve recentemente, juntamente com a crise da COVID-19, tivemos grandes problemas para comportar a grande demanda de pacientes que passam pela nossa clínica. Além do gasto com as alterações estruturais para adequar a clínica às normas governamentais durante esse período, tivemos grandes despesas com a contratação de funcionários para realizar o primeiro atendimento e agendamento das consultas via telefone, o que acabou impactando diretamente no nosso budget de contratação de mais profissionais especializados para tratar nosso número crescente de pacientes.

Hoje, por mais que esse número tenha diminuído um pouco, ainda estamos sentindo o impacto dos últimos anos e achamos que seria o momento de buscar modernizar algumas partes do processo de agendamento de consulta e de recepção dos pacientes, levando em conta o nosso público.
___________________________________________________________

### ARQUITETURA: 

Criação de uma aplicação web que permita o agendamento de consultas. A aplicação e a base de dados ficarão armazenados em nuvem pública para aproveitarmos a escalabilidade e melhores preços para servidores. Dessa forma podemos aumentar a capacidade da aplicação em épocas críticas, como foi durante a crise da COVID-19, e reduzimos quando estes períodos passarem. A integração com canais de chat como WhatsApp agilizam o processo de contatação, permitindo gerenciar o agendamento de maneira assíncrona. Além de permitir que um funcionário atenda a mais de um cliente por vez. O sistema permite priorizar pacientes e controlar a alocação por grau de infecciosidade, sendo possível configurar os quartos disponíveis no sistema de acordo com  oque as instalações do hospital possuem. O sistema possuíra integração com bancos para permitir pagamento com cartão, parcelamento, e outras formas de pagamentos. 

A aplicação traria, mais especificamente, as seguintes funcionalidades: 

RQ1. Cadastrar funcionários, pacientes, médicos e enfermeiros
RQ2. Gerenciar agenda dos médicos e alocação em quartos
RQ3. Categorizar nível de prioridade de atendimento
RQ4. Organizar alocação por grau de infecciosidade
RQ5. Realizar cobranças e aceitar pagamentos de diferentes formas
RQ6. Interação com cliente multiplataforma (web, app, whatsapp)

### Refinamento de Requisitos
Sistema de agendamento de consultas

Funcionalidades: 
RQ1. Cadastrar funcionários, pacientes, médicos e enfermeiros
	1.1 Criação de entidades e relacionamentos para armazenar pacientes, médicos e enfermeiros, com até 6 tabelas e 10 colunas em cada tabela.
	1.2 Criação de tela para cadastro de pacientes, médicos e enfermeiros. 
	1.3 Criação de perfis de acesso para gerenciar quem pode realizar cadastros
		1.3.1 - Atendentes -> Cadastram pacientes// Administrador -> Cadastra atendentes, médicos e enfermeiros
		
RQ2. Gerenciar agenda dos médicos e alocação em quartos
	2.1 Criação de entidades e relacionamentos para gerenciar a agenda, com até 3 tabelas e 10 colunas em cada tabela.
	2.2 Criação de tela para reserva de macas e quartos
	2.3 Criação de tela para cadastro de macas e quartos
	2.4 Criação de tela para agendamento (relacionamento entre quarto x maca x paciente x periculosidade x médico x data de entrada e previsão de saída)
	
RQ3. Categorizar nível de prioridade de atendimento
	3.1 Criação de entidades e relacionamentos para gerenciar razão do atendimento e grau de periculosidade, com até 3 tabelas e 10 colunas em cada tabela.
	3.2 Disponibilizar na tela de agendamento opção de "Atendimento prioritário"
	3.2 Disponibilizar na tela de cadastro de quartos e macas opção para "Reservado - Atendimento Prioritário"
	
RQ4. Organizar alocação por grau de infecciosidade
	4.1 Criação de regras para impedir alocação de pacientes com alto grau de infecciosidade em quartos compartilhados
	
RQ5. Realizar cobranças e aceitar pagamentos de diferentes formas
	5.1 Criação de integração com um banco para geração de boletos
	5.2 Tela para pagamentos (perfil clientes)
	5.3 Tela para consultar e emitir relatório de pagamentos (perfil administrativo)
RQ6. Interação com cliente multiplataforma (web, app, whatsapp)
	6.1 Criação de integração com api do WhatsApp

Premissa: Criar uma aplicação web alocada em servidor de núvem pública. 
