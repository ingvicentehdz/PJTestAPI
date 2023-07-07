﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class DBPJContext : DbContext
    {
        public DBPJContext()
        {
        }

        public DBPJContext(DbContextOptions<DBPJContext> options)
            : base(options)
        {
        }

        public virtual DbSet<_001area> _001areas { get; set; }
        public virtual DbSet<_001areas058tiposTocasOrale> _001areas058tiposTocasOrales { get; set; }
        public virtual DbSet<_002materia> _002materias { get; set; }
        public virtual DbSet<_003areasMateria> _003areasMaterias { get; set; }
        public virtual DbSet<_003areasMaterias004tiposDocumento> _003areasMaterias004tiposDocumentos { get; set; }
        public virtual DbSet<_003areasMaterias024tiposAudiencium> _003areasMaterias024tiposAudiencia { get; set; }
        public virtual DbSet<_004tiposDocumento> _004tiposDocumentos { get; set; }
        public virtual DbSet<_004tiposDocumento059tiposRecurso> _004tiposDocumento059tiposRecursos { get; set; }
        public virtual DbSet<_005puestosJuridico> _005puestosJuridicos { get; set; }
        public virtual DbSet<_006puestosAdministrativo> _006puestosAdministrativos { get; set; }
        public virtual DbSet<_007evidenciasFirmaElectronica> _007evidenciasFirmaElectronicas { get; set; }
        public virtual DbSet<_008delito> _008delitos { get; set; }
        public virtual DbSet<_008delitos013tiposDelito> _008delitos013tiposDelitos { get; set; }
        public virtual DbSet<_008delitos053articulo> _008delitos053articulos { get; set; }
        public virtual DbSet<_009partidosJudiciale> _009partidosJudiciales { get; set; }
        public virtual DbSet<_010municipio> _010municipios { get; set; }
        public virtual DbSet<_011entidadesFederativa> _011entidadesFederativas { get; set; }
        public virtual DbSet<_012tiposSexo> _012tiposSexos { get; set; }
        public virtual DbSet<_013tiposDelito> _013tiposDelitos { get; set; }
        public virtual DbSet<_014tiposAbogado> _014tiposAbogados { get; set; }
        public virtual DbSet<_015despacho> _015despachos { get; set; }
        public virtual DbSet<_016domicilio> _016domicilios { get; set; }
        public virtual DbSet<_017tiposDomicilio> _017tiposDomicilios { get; set; }
        public virtual DbSet<_018telefono> _018telefonos { get; set; }
        public virtual DbSet<_019tiposTelefono> _019tiposTelefonos { get; set; }
        public virtual DbSet<_020sala> _020salas { get; set; }
        public virtual DbSet<_021tiposDespacho> _021tiposDespachos { get; set; }
        public virtual DbSet<_022dependenciasPublica> _022dependenciasPublicas { get; set; }
        public virtual DbSet<_023diasInhabile> _023diasInhabiles { get; set; }
        public virtual DbSet<_024tiposAudiencium> _024tiposAudiencia { get; set; }
        public virtual DbSet<_025basesDeDato> _025basesDeDatos { get; set; }
        public virtual DbSet<_026tiposJuez> _026tiposJuezs { get; set; }
        public virtual DbSet<_027tiposTitulo> _027tiposTitulos { get; set; }
        public virtual DbSet<_028tiposPersona> _028tiposPersonas { get; set; }
        public virtual DbSet<_029tiposPersonalidad> _029tiposPersonalidads { get; set; }
        public virtual DbSet<_029tiposPersonalidad002materia> _029tiposPersonalidad002materias { get; set; }
        public virtual DbSet<_030tiposTutor> _030tiposTutors { get; set; }
        public virtual DbSet<_031sistema> _031sistemas { get; set; }
        public virtual DbSet<_032tiposSistema> _032tiposSistemas { get; set; }
        public virtual DbSet<_033tiposBienJuridico> _033tiposBienJuridicos { get; set; }
        public virtual DbSet<_034tiposEvidencium> _034tiposEvidencia { get; set; }
        public virtual DbSet<_035tiposRegistro> _035tiposRegistros { get; set; }
        public virtual DbSet<_036tiposMovimiento> _036tiposMovimientos { get; set; }
        public virtual DbSet<_037paise> _037paises { get; set; }
        public virtual DbSet<_038tiposIdentificacion> _038tiposIdentificacions { get; set; }
        public virtual DbSet<_039tiposDepartamento> _039tiposDepartamentos { get; set; }
        public virtual DbSet<_040tiposDepartamentosArea> _040tiposDepartamentosAreas { get; set; }
        public virtual DbSet<_040tiposDepartamentosAreas045puesto> _040tiposDepartamentosAreas045puestos { get; set; }
        public virtual DbSet<_041tiposEstadoCivil> _041tiposEstadoCivils { get; set; }
        public virtual DbSet<_042juicio> _042juicios { get; set; }
        public virtual DbSet<_043coloresCaratula> _043coloresCaratulas { get; set; }
        public virtual DbSet<_044tiposPuesto> _044tiposPuestos { get; set; }
        public virtual DbSet<_045puesto> _045puestos { get; set; }
        public virtual DbSet<_046tramite> _046tramites { get; set; }
        public virtual DbSet<_047tiposParentesco> _047tiposParentescos { get; set; }
        public virtual DbSet<_048tiposFirmaElectronica> _048tiposFirmaElectronicas { get; set; }
        public virtual DbSet<_049autoridadesFederale> _049autoridadesFederales { get; set; }
        public virtual DbSet<_050tiposAutoridadFederal> _050tiposAutoridadFederals { get; set; }
        public virtual DbSet<_051anexo> _051anexos { get; set; }
        public virtual DbSet<_052nivelesPuesto> _052nivelesPuestos { get; set; }
        public virtual DbSet<_053articulo> _053articulos { get; set; }
        public virtual DbSet<_054fraccione> _054fracciones { get; set; }
        public virtual DbSet<_055inciso> _055incisos { get; set; }
        public virtual DbSet<_057tiposIcono> _057tiposIconos { get; set; }
        public virtual DbSet<_058tiposTocasOrale> _058tiposTocasOrales { get; set; }
        public virtual DbSet<_058tiposTocasOrales059tiposRecurso> _058tiposTocasOrales059tiposRecursos { get; set; }
        public virtual DbSet<_059tiposRecurso> _059tiposRecursos { get; set; }
        public virtual DbSet<_060tiposCategoriasPuesto> _060tiposCategoriasPuestos { get; set; }
        public virtual DbSet<_062tiposCorreosElectronico> _062tiposCorreosElectronicos { get; set; }
        public virtual DbSet<_063areasSistema> _063areasSistemas { get; set; }
        public virtual DbSet<_064tiposClasificacionPerspectivaDeGenero> _064tiposClasificacionPerspectivaDeGeneros { get; set; }
        public virtual DbSet<_065caracteristicasPerspectivaDeGenero> _065caracteristicasPerspectivaDeGeneros { get; set; }
        public virtual DbSet<_066solicitudFirmaElectronicaMultiple> _066solicitudFirmaElectronicaMultiples { get; set; }
        public virtual DbSet<_067usuariosFirmaElectronicaMultiple> _067usuariosFirmaElectronicaMultiples { get; set; }
        public virtual DbSet<_068puestosOficiale> _068puestosOficiales { get; set; }
        public virtual DbSet<_069tipoResolucion> _069tipoResolucions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=172.16.20.10;Database=DBPJ;user=sa;password=Des2016$;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<_001area>(entity =>
            {
                entity.ToTable("001Areas");

                entity.Property(e => e._001areaId).HasColumnName("001AreaId");

                entity.Property(e => e._001abreviatura)
                    .HasMaxLength(10)
                    .HasColumnName("001Abreviatura");

                entity.Property(e => e._001activo).HasColumnName("001Activo");

                entity.Property(e => e._001alias)
                    .HasMaxLength(250)
                    .HasColumnName("001Alias");

                entity.Property(e => e._001areaEvaluacionesId).HasColumnName("001AreaEvaluacionesId");

                entity.Property(e => e._001areaIdArchivo).HasColumnName("001AreaId_Archivo");

                entity.Property(e => e._001areaIdEquitas).HasColumnName("001AreaId_Equitas");

                entity.Property(e => e._001areaIdMajat).HasColumnName("001AreaId_Majat");

                entity.Property(e => e._001correoElectronico).HasColumnName("001CorreoElectronico");

                entity.Property(e => e._001nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("001Nombre");

                entity.Property(e => e._009partidoJudicialId).HasColumnName("009PartidoJudicialId");

                entity.Property(e => e._010municipioId).HasColumnName("010MunicipioId");

                entity.HasOne(d => d._009partidoJudicial)
                    .WithMany(p => p._001areas)
                    .HasForeignKey(d => d._009partidoJudicialId)
                    .HasConstraintName("FK__001Areas__009Par__4E53A1AA");

                entity.HasOne(d => d._010municipio)
                    .WithMany(p => p._001areas)
                    .HasForeignKey(d => d._010municipioId)
                    .HasConstraintName("FK_001Area_010Municipios");
            });

            modelBuilder.Entity<_001areas058tiposTocasOrale>(entity =>
            {
                entity.HasKey(e => new { e._001areaId, e._058tipoTocaOralId });

                entity.ToTable("001Areas_058TiposTocasOrales");

                entity.Property(e => e._001areaId).HasColumnName("001AreaId");

                entity.Property(e => e._058tipoTocaOralId).HasColumnName("058TipoTocaOralId");

                entity.HasOne(d => d._001area)
                    .WithMany(p => p._001areas058tiposTocasOrales)
                    .HasForeignKey(d => d._001areaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_001Areas_058TiposTocasOrales_001Areas");

                entity.HasOne(d => d._058tipoTocaOral)
                    .WithMany(p => p._001areas058tiposTocasOrales)
                    .HasForeignKey(d => d._058tipoTocaOralId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_001Areas_058TiposTocasOrales_058TiposTocasOrales");
            });

            modelBuilder.Entity<_002materia>(entity =>
            {
                entity.ToTable("002Materias");

                entity.Property(e => e._002materiaId).HasColumnName("002MateriaId");

                entity.Property(e => e._002activo)
                    .IsRequired()
                    .HasColumnName("002Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._002materiaIdEquitas).HasColumnName("002MateriaId_Equitas");

                entity.Property(e => e._002materiaIdMajat).HasColumnName("002MateriaId_Majat");

                entity.Property(e => e._002nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("002Nombre");
            });

            modelBuilder.Entity<_003areasMateria>(entity =>
            {
                entity.HasKey(e => e._003areaMateriaId)
                    .HasName("PK_AreaMateria");

                entity.ToTable("003AreasMaterias");

                entity.Property(e => e._003areaMateriaId).HasColumnName("003AreaMateriaId");

                entity.Property(e => e._001areaId).HasColumnName("001AreaId");

                entity.Property(e => e._002materiaId).HasColumnName("002MateriaId");

                entity.HasOne(d => d._001area)
                    .WithMany(p => p._003areasMateria)
                    .HasForeignKey(d => d._001areaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AreaMateria_Area");

                entity.HasOne(d => d._002materia)
                    .WithMany(p => p._003areasMateria)
                    .HasForeignKey(d => d._002materiaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AreaMateria_Materia");
            });

            modelBuilder.Entity<_003areasMaterias004tiposDocumento>(entity =>
            {
                entity.HasKey(e => new { e._003areaMateriaId, e._004tipoDocumentoId });

                entity.ToTable("003AreasMaterias_004TiposDocumento");

                entity.Property(e => e._003areaMateriaId).HasColumnName("003AreaMateriaId");

                entity.Property(e => e._004tipoDocumentoId).HasColumnName("004TipoDocumentoId");

                entity.HasOne(d => d._003areaMateria)
                    .WithMany(p => p._003areasMaterias004tiposDocumentos)
                    .HasForeignKey(d => d._003areaMateriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_003AreasMaterias_004TiposDocumento_003AreasMaterias");

                entity.HasOne(d => d._004tipoDocumento)
                    .WithMany(p => p._003areasMaterias004tiposDocumentos)
                    .HasForeignKey(d => d._004tipoDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_003AreasMaterias_004TiposDocumento_004TiposDocumento");
            });

            modelBuilder.Entity<_003areasMaterias024tiposAudiencium>(entity =>
            {
                entity.HasKey(e => new { e._003areaMateriaId, e._024tipoAudienciaId });

                entity.ToTable("003AreasMaterias_024TiposAudiencia");

                entity.Property(e => e._003areaMateriaId).HasColumnName("003AreaMateriaId");

                entity.Property(e => e._024tipoAudienciaId).HasColumnName("024TipoAudienciaId");

                entity.HasOne(d => d._003areaMateria)
                    .WithMany(p => p._003areasMaterias024tiposAudiencia)
                    .HasForeignKey(d => d._003areaMateriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_003AreasMaterias_024TiposAudiencia_003AreasMaterias");

                entity.HasOne(d => d._024tipoAudiencia)
                    .WithMany(p => p._003areasMaterias024tiposAudiencia)
                    .HasForeignKey(d => d._024tipoAudienciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_003AreasMaterias_024TiposAudiencia_024TiposAudiencia");
            });

            modelBuilder.Entity<_004tiposDocumento>(entity =>
            {
                entity.HasKey(e => e._004tipoDocumentoId)
                    .HasName("PK_TipoDocumento");

                entity.ToTable("004TiposDocumento");

                entity.Property(e => e._004tipoDocumentoId)
                    .ValueGeneratedNever()
                    .HasColumnName("004TipoDocumentoId");

                entity.Property(e => e._004activo)
                    .IsRequired()
                    .HasColumnName("004Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._004descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("004Descripcion");

                entity.Property(e => e._004documentoPrincipal).HasColumnName("004DocumentoPrincipal");

                entity.Property(e => e._004tipoDocumentoIdEquitas).HasColumnName("004TipoDocumentoId_Equitas");

                entity.Property(e => e._004tipoDocumentoIdMajat).HasColumnName("004TipoDocumentoId_Majat");
            });

            modelBuilder.Entity<_004tiposDocumento059tiposRecurso>(entity =>
            {
                entity.HasKey(e => new { e._004tipoDocumentoId, e._059tipoRecursoId });

                entity.ToTable("004TiposDocumento_059TiposRecursos");

                entity.Property(e => e._004tipoDocumentoId).HasColumnName("004TipoDocumentoId");

                entity.Property(e => e._059tipoRecursoId).HasColumnName("059TipoRecursoId");

                entity.HasOne(d => d._004tipoDocumento)
                    .WithMany(p => p._004tiposDocumento059tiposRecursos)
                    .HasForeignKey(d => d._004tipoDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_004TiposDocumento_059TiposRecursos_004TiposDocumento");

                entity.HasOne(d => d._059tipoRecurso)
                    .WithMany(p => p._004tiposDocumento059tiposRecursos)
                    .HasForeignKey(d => d._059tipoRecursoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_004TiposDocumento_059TiposRecursos_059TiposRecursos");
            });

            modelBuilder.Entity<_005puestosJuridico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("005PuestosJuridicos");

                entity.Property(e => e._005activo)
                    .IsRequired()
                    .HasColumnName("005Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._005nombre)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("005Nombre");

                entity.Property(e => e._005puestoJuridicoId).HasColumnName("005PuestoJuridicoId");

                entity.Property(e => e._005puestoJuridicoId36equitas).HasColumnName("005PuestoJuridicoId_36Equitas");
            });

            modelBuilder.Entity<_006puestosAdministrativo>(entity =>
            {
                entity.HasKey(e => e._006puestoAdministrativoId)
                    .HasName("PK__006Puest__353C19FB3B99F57A");

                entity.ToTable("006PuestosAdministrativos");

                entity.Property(e => e._006puestoAdministrativoId)
                    .ValueGeneratedNever()
                    .HasColumnName("006PuestoAdministrativoId");

                entity.Property(e => e._006activo)
                    .IsRequired()
                    .HasColumnName("006Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._006nombre)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("006Nombre");
            });

            modelBuilder.Entity<_007evidenciasFirmaElectronica>(entity =>
            {
                entity.HasKey(e => e._007evidenciaFirmaElectronicaId)
                    .HasName("PK_007EvidenciaFirmaElectronica");

                entity.ToTable("007EvidenciasFirmaElectronica");

                entity.Property(e => e._007evidenciaFirmaElectronicaId).HasColumnName("007EvidenciaFirmaElectronicaId");

                entity.Property(e => e._0007fechaCreado)
                    .HasColumnType("datetime")
                    .HasColumnName("0007FechaCreado");

                entity.Property(e => e._007rutaCarpetaEvidencias)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("007RutaCarpetaEvidencias");

                entity.Property(e => e._007usuarioQueFirma001Dbcuentas).HasColumnName("007UsuarioQueFirma001DBCUENTAS");
            });

            modelBuilder.Entity<_008delito>(entity =>
            {
                entity.ToTable("008Delitos");

                entity.Property(e => e._008delitoId)
                    .ValueGeneratedNever()
                    .HasColumnName("008DelitoId");

                entity.Property(e => e._008activo).HasColumnName("008Activo");

                entity.Property(e => e._008codigo)
                    .HasMaxLength(10)
                    .HasColumnName("008Codigo");

                entity.Property(e => e._008delitoIdEquitas).HasColumnName("008DelitoId_Equitas");

                entity.Property(e => e._008delitoIdMajat).HasColumnName("008DelitoId_Majat");

                entity.Property(e => e._008nombre)
                    .IsUnicode(false)
                    .HasColumnName("008Nombre");

                entity.Property(e => e._033tipoBienJuridicoId).HasColumnName("033TipoBienJuridicoId");

                entity.HasOne(d => d._033tipoBienJuridico)
                    .WithMany(p => p._008delitos)
                    .HasForeignKey(d => d._033tipoBienJuridicoId)
                    .HasConstraintName("FK__008Delito__033Ti__2AD55B43");
            });

            modelBuilder.Entity<_008delitos013tiposDelito>(entity =>
            {
                entity.HasKey(e => new { e._008delitoId, e._013tipoDelitoId });

                entity.ToTable("008Delitos_013TiposDelito");

                entity.Property(e => e._008delitoId).HasColumnName("008DelitoId");

                entity.Property(e => e._013tipoDelitoId).HasColumnName("013TipoDelitoId");

                entity.HasOne(d => d._008delito)
                    .WithMany(p => p._008delitos013tiposDelitos)
                    .HasForeignKey(d => d._008delitoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_008Delitos_013TiposDelito_008Delitos");

                entity.HasOne(d => d._013tipoDelito)
                    .WithMany(p => p._008delitos013tiposDelitos)
                    .HasForeignKey(d => d._013tipoDelitoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_008Delitos_013TiposDelito_013TiposDelito");
            });

            modelBuilder.Entity<_008delitos053articulo>(entity =>
            {
                entity.HasKey(e => new { e._008delitoId, e._053articuloId });

                entity.ToTable("008Delitos_053Articulos");

                entity.Property(e => e._008delitoId).HasColumnName("008DelitoId");

                entity.Property(e => e._053articuloId).HasColumnName("053ArticuloId");

                entity.HasOne(d => d._008delito)
                    .WithMany(p => p._008delitos053articulos)
                    .HasForeignKey(d => d._008delitoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_008Delitos_053Articulos_008Delitos");

                entity.HasOne(d => d._053articulo)
                    .WithMany(p => p._008delitos053articulos)
                    .HasForeignKey(d => d._053articuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_008Delitos_053Articulos_053Articulos");
            });

            modelBuilder.Entity<_009partidosJudiciale>(entity =>
            {
                entity.HasKey(e => e._009partidoJudicialId);

                entity.ToTable("009PartidosJudiciales");

                entity.Property(e => e._009partidoJudicialId).HasColumnName("009PartidoJudicialId");

                entity.Property(e => e._009activo).HasColumnName("009Activo");

                entity.Property(e => e._009nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("009Nombre");
            });

            modelBuilder.Entity<_010municipio>(entity =>
            {
                entity.ToTable("010Municipios");

                entity.Property(e => e._010municipioId)
                    .ValueGeneratedNever()
                    .HasColumnName("010MunicipioId");

                entity.Property(e => e._009partidoJudicialId).HasColumnName("009PartidoJudicialId");

                entity.Property(e => e._010activo)
                    .IsRequired()
                    .HasColumnName("010Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._010codigo)
                    .HasMaxLength(10)
                    .HasColumnName("010Codigo");

                entity.Property(e => e._010nombre)
                    .IsRequired()
                    .HasColumnName("010Nombre");

                entity.Property(e => e._011entidadFederativaId).HasColumnName("011EntidadFederativaId");

                entity.HasOne(d => d._009partidoJudicial)
                    .WithMany(p => p._010municipios)
                    .HasForeignKey(d => d._009partidoJudicialId)
                    .HasConstraintName("FK_010Municipios_009PartidosJudiciales");

                entity.HasOne(d => d._011entidadFederativa)
                    .WithMany(p => p._010municipios)
                    .HasForeignKey(d => d._011entidadFederativaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_010Municipios_011EntidadesFederativas");
            });

            modelBuilder.Entity<_011entidadesFederativa>(entity =>
            {
                entity.HasKey(e => e._011entidadFederativaId);

                entity.ToTable("011EntidadesFederativas");

                entity.Property(e => e._011entidadFederativaId).HasColumnName("011EntidadFederativaId");

                entity.Property(e => e._011activo)
                    .IsRequired()
                    .HasColumnName("011Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._011codigo)
                    .HasMaxLength(10)
                    .HasColumnName("011Codigo");

                entity.Property(e => e._011nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("011Nombre");

                entity.Property(e => e._037paisId).HasColumnName("037PaisId");

                entity.HasOne(d => d._037pais)
                    .WithMany(p => p._011entidadesFederativas)
                    .HasForeignKey(d => d._037paisId)
                    .HasConstraintName("FK__011Entida__037Pa__2BC97F7C");
            });

            modelBuilder.Entity<_012tiposSexo>(entity =>
            {
                entity.HasKey(e => e._012tipoSexoId);

                entity.ToTable("012TiposSexo");

                entity.Property(e => e._012tipoSexoId)
                    .ValueGeneratedNever()
                    .HasColumnName("012TipoSexoId");

                entity.Property(e => e._012abreviatura)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("012Abreviatura")
                    .IsFixedLength(true);

                entity.Property(e => e._012activo).HasColumnName("012Activo");

                entity.Property(e => e._012nombre)
                    .IsRequired()
                    .HasColumnName("012Nombre");
            });

            modelBuilder.Entity<_013tiposDelito>(entity =>
            {
                entity.HasKey(e => e._013tipoDelitoId);

                entity.ToTable("013TiposDelito");

                entity.Property(e => e._013tipoDelitoId)
                    .ValueGeneratedNever()
                    .HasColumnName("013TipoDelitoId");

                entity.Property(e => e._013activo).HasColumnName("013Activo");

                entity.Property(e => e._013codigo)
                    .HasMaxLength(10)
                    .HasColumnName("013Codigo");

                entity.Property(e => e._013nombre)
                    .IsRequired()
                    .HasColumnName("013Nombre");
            });

            modelBuilder.Entity<_014tiposAbogado>(entity =>
            {
                entity.HasKey(e => e._014tipoAbogadoId);

                entity.ToTable("014TiposAbogado");

                entity.Property(e => e._014tipoAbogadoId)
                    .ValueGeneratedNever()
                    .HasColumnName("014TipoAbogadoId");

                entity.Property(e => e._014activo).HasColumnName("014Activo");

                entity.Property(e => e._014nombre)
                    .IsRequired()
                    .HasColumnName("014Nombre");
            });

            modelBuilder.Entity<_015despacho>(entity =>
            {
                entity.ToTable("015Despachos");

                entity.Property(e => e._015despachoId).HasColumnName("015DespachoId");

                entity.Property(e => e._014abogadoIdDbcuentas).HasColumnName("014AbogadoId_DBCuentas");

                entity.Property(e => e._015activo).HasColumnName("015Activo");

                entity.Property(e => e._015nombre).HasColumnName("015Nombre");

                entity.Property(e => e._021tipoDespachoId).HasColumnName("021TipoDespachoId");

                entity.Property(e => e._022dependenciaPublicaId).HasColumnName("022DependenciaPublicaId");

                entity.HasOne(d => d._021tipoDespacho)
                    .WithMany(p => p._015despachos)
                    .HasForeignKey(d => d._021tipoDespachoId)
                    .HasConstraintName("FK_015Despacho_021TipoDespacho");

                entity.HasOne(d => d._022dependenciaPublica)
                    .WithMany(p => p._015despachos)
                    .HasForeignKey(d => d._022dependenciaPublicaId)
                    .HasConstraintName("FK_015Despacho_022DependenciaPublica");
            });

            modelBuilder.Entity<_016domicilio>(entity =>
            {
                entity.ToTable("016Domicilios");

                entity.Property(e => e._016domicilioId).HasColumnName("016DomicilioId");

                entity.Property(e => e._010municipioId).HasColumnName("010MunicipioId");

                entity.Property(e => e._011entidadFederativaId).HasColumnName("011EntidadFederativaId");

                entity.Property(e => e._015despachoId).HasColumnName("015DespachoId");

                entity.Property(e => e._016calle).HasColumnName("016Calle");

                entity.Property(e => e._016codigoPostal).HasColumnName("016CodigoPostal");

                entity.Property(e => e._016fraccColonia)
                    .IsRequired()
                    .HasColumnName("016FraccColonia");

                entity.Property(e => e._016numeroExterno).HasColumnName("016NumeroExterno");

                entity.Property(e => e._016numeroInterno).HasColumnName("016NumeroInterno");

                entity.Property(e => e._017tipoDomicilioId).HasColumnName("017TipoDomicilioId");

                entity.HasOne(d => d._015despacho)
                    .WithMany(p => p._016domicilios)
                    .HasForeignKey(d => d._015despachoId)
                    .HasConstraintName("FK_016Domicilio_015Despacho");

                entity.HasOne(d => d._017tipoDomicilio)
                    .WithMany(p => p._016domicilios)
                    .HasForeignKey(d => d._017tipoDomicilioId)
                    .HasConstraintName("FK_016Domicilio_017TipoDomicilio");
            });

            modelBuilder.Entity<_017tiposDomicilio>(entity =>
            {
                entity.HasKey(e => e._017tipoDomicilioId)
                    .HasName("PK_017TipoDomicilio");

                entity.ToTable("017TiposDomicilio");

                entity.Property(e => e._017tipoDomicilioId)
                    .ValueGeneratedNever()
                    .HasColumnName("017TipoDomicilioId");

                entity.Property(e => e._017activo).HasColumnName("017Activo");

                entity.Property(e => e._017nombre)
                    .IsRequired()
                    .HasColumnName("017Nombre");
            });

            modelBuilder.Entity<_018telefono>(entity =>
            {
                entity.ToTable("018Telefonos");

                entity.Property(e => e._018telefonoId).HasColumnName("018TelefonoId");

                entity.Property(e => e._016domicilioId).HasColumnName("016DomicilioId");

                entity.Property(e => e._018extension).HasColumnName("018Extension");

                entity.Property(e => e._018numero)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("018Numero");

                entity.Property(e => e._019tipoTelefonoId).HasColumnName("019TipoTelefonoId");

                entity.HasOne(d => d._016domicilio)
                    .WithMany(p => p._018telefonos)
                    .HasForeignKey(d => d._016domicilioId)
                    .HasConstraintName("FK_018Telefono_016Domicilio");

                entity.HasOne(d => d._019tipoTelefono)
                    .WithMany(p => p._018telefonos)
                    .HasForeignKey(d => d._019tipoTelefonoId)
                    .HasConstraintName("FK_018Telefono_019TipoTelefono");
            });

            modelBuilder.Entity<_019tiposTelefono>(entity =>
            {
                entity.HasKey(e => e._019tipoTelefonoId)
                    .HasName("PK_019TipoTelefono");

                entity.ToTable("019TiposTelefono");

                entity.Property(e => e._019tipoTelefonoId)
                    .ValueGeneratedNever()
                    .HasColumnName("019TipoTelefonoId");

                entity.Property(e => e._019activo).HasColumnName("019Activo");

                entity.Property(e => e._019nombre)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("019Nombre");
            });

            modelBuilder.Entity<_020sala>(entity =>
            {
                entity.ToTable("020Salas");

                entity.Property(e => e._020salaId)
                    .ValueGeneratedNever()
                    .HasColumnName("020SalaId");

                entity.Property(e => e._001areaId).HasColumnName("001AreaId");

                entity.Property(e => e._009partidoJudicialId).HasColumnName("009PartidoJudicialId");

                entity.Property(e => e._020activo).HasColumnName("020Activo");

                entity.Property(e => e._020ip).HasColumnName("020IP");

                entity.Property(e => e._020ipdeTransmision).HasColumnName("020IPDeTransmision");

                entity.Property(e => e._020nombre)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("020Nombre");

                entity.Property(e => e._020puertoDeFinalizacion).HasColumnName("020PuertoDeFinalizacion");

                entity.Property(e => e._020puertoDeGrabacion).HasColumnName("020PuertoDeGrabacion");

                entity.HasOne(d => d._001area)
                    .WithMany(p => p._020salas)
                    .HasForeignKey(d => d._001areaId)
                    .HasConstraintName("FK_020Salas_001Areas");

                entity.HasOne(d => d._009partidoJudicial)
                    .WithMany(p => p._020salas)
                    .HasForeignKey(d => d._009partidoJudicialId)
                    .HasConstraintName("FK_020Sala_009PartidosJudiciales");
            });

            modelBuilder.Entity<_021tiposDespacho>(entity =>
            {
                entity.HasKey(e => e._021tipoDespachoId)
                    .HasName("PK_021TipoDespacho");

                entity.ToTable("021TiposDespacho");

                entity.Property(e => e._021tipoDespachoId)
                    .ValueGeneratedNever()
                    .HasColumnName("021TipoDespachoId");

                entity.Property(e => e._021activo).HasColumnName("021Activo");

                entity.Property(e => e._021nombre).HasColumnName("021Nombre");
            });

            modelBuilder.Entity<_022dependenciasPublica>(entity =>
            {
                entity.HasKey(e => e._022dependenciaPublicaId)
                    .HasName("PK_022DependenciaPublica");

                entity.ToTable("022DependenciasPublicas");

                entity.Property(e => e._022dependenciaPublicaId)
                    .ValueGeneratedNever()
                    .HasColumnName("022DependenciaPublicaId");

                entity.Property(e => e._022activo).HasColumnName("022Activo");

                entity.Property(e => e._022nombre)
                    .IsRequired()
                    .HasColumnName("022Nombre");
            });

            modelBuilder.Entity<_023diasInhabile>(entity =>
            {
                entity.HasKey(e => e._023diaInhabil);

                entity.ToTable("023DiasInhabiles");

                entity.Property(e => e._023diaInhabil)
                    .HasColumnType("date")
                    .HasColumnName("023DiaInhabil");
            });

            modelBuilder.Entity<_024tiposAudiencium>(entity =>
            {
                entity.HasKey(e => e._024tipoAudienciaId)
                    .HasName("PK_024TipoAudiencia");

                entity.ToTable("024TiposAudiencia");

                entity.Property(e => e._024tipoAudienciaId)
                    .ValueGeneratedNever()
                    .HasColumnName("024TipoAudienciaId");

                entity.Property(e => e._002materiaId).HasColumnName("002MateriaId");

                entity.Property(e => e._024activo).HasColumnName("024Activo");

                entity.Property(e => e._024nombre)
                    .IsRequired()
                    .HasColumnName("024Nombre");

                entity.Property(e => e._024tipoAudienciaIdEquitas).HasColumnName("024TipoAudienciaId_Equitas");

                entity.Property(e => e._024tipoAudienciaIdSiop).HasColumnName("024TipoAudienciaId_SIOP");

                entity.HasOne(d => d._002materia)
                    .WithMany(p => p._024tiposAudiencia)
                    .HasForeignKey(d => d._002materiaId)
                    .HasConstraintName("FK_024TiposAudiencia_002Materias");
            });

            modelBuilder.Entity<_025basesDeDato>(entity =>
            {
                entity.HasKey(e => e._025baseDeDatosId)
                    .HasName("PK_025TiposBasesDeDatos");

                entity.ToTable("025BasesDeDatos");

                entity.Property(e => e._025baseDeDatosId)
                    .ValueGeneratedNever()
                    .HasColumnName("025BaseDeDatosId");

                entity.Property(e => e._025activo)
                    .IsRequired()
                    .HasColumnName("025Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._025descripcion)
                    .IsRequired()
                    .HasColumnName("025Descripcion");

                entity.Property(e => e._025nombre)
                    .IsRequired()
                    .HasColumnName("025Nombre");
            });

            modelBuilder.Entity<_026tiposJuez>(entity =>
            {
                entity.HasKey(e => e._026tipoJuezId);

                entity.ToTable("026TiposJuez");

                entity.Property(e => e._026tipoJuezId)
                    .ValueGeneratedNever()
                    .HasColumnName("026TipoJuezId");

                entity.Property(e => e._026activo).HasColumnName("026Activo");

                entity.Property(e => e._026nombre)
                    .IsRequired()
                    .HasColumnName("026Nombre");
            });

            modelBuilder.Entity<_027tiposTitulo>(entity =>
            {
                entity.HasKey(e => e._027tipoTituloId);

                entity.ToTable("027TiposTitulo");

                entity.Property(e => e._027tipoTituloId)
                    .ValueGeneratedNever()
                    .HasColumnName("027TipoTituloId");

                entity.Property(e => e._027activo).HasColumnName("027Activo");

                entity.Property(e => e._027nombre)
                    .IsRequired()
                    .HasColumnName("027Nombre");

                entity.Property(e => e._027tituloIdMajat).HasColumnName("027TituloId_Majat");
            });

            modelBuilder.Entity<_028tiposPersona>(entity =>
            {
                entity.HasKey(e => e._028tipoPersonaId);

                entity.ToTable("028TiposPersona");

                entity.Property(e => e._028tipoPersonaId).HasColumnName("028TipoPersonaId");

                entity.Property(e => e._028activo).HasColumnName("028Activo");

                entity.Property(e => e._028nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("028Nombre");

                entity.Property(e => e._028tipoSujetoIdMajat).HasColumnName("028TipoSujetoId_Majat");
            });

            modelBuilder.Entity<_029tiposPersonalidad>(entity =>
            {
                entity.HasKey(e => e._029tipoPersonalidadId);

                entity.ToTable("029TiposPersonalidad");

                entity.Property(e => e._029tipoPersonalidadId).HasColumnName("029TipoPersonalidadId");

                entity.Property(e => e._029activo).HasColumnName("029Activo");

                entity.Property(e => e._029nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("029Nombre");

                entity.Property(e => e._029tipoPersonalidadId53equitas).HasColumnName("029TipoPersonalidadId_53Equitas");

                entity.Property(e => e._029tipoPersonalidadIdMajat).HasColumnName("029TipoPersonalidadId_Majat");
            });

            modelBuilder.Entity<_029tiposPersonalidad002materia>(entity =>
            {
                entity.HasKey(e => new { e._029tipoPersonalidadId, e._002materiaId });

                entity.ToTable("029TiposPersonalidad_002Materias");

                entity.Property(e => e._029tipoPersonalidadId).HasColumnName("029TipoPersonalidadId");

                entity.Property(e => e._002materiaId).HasColumnName("002MateriaId");

                entity.HasOne(d => d._002materia)
                    .WithMany(p => p._029tiposPersonalidad002materia)
                    .HasForeignKey(d => d._002materiaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_029TiposPersonalidad_002Materias_002Materias");

                entity.HasOne(d => d._029tipoPersonalidad)
                    .WithMany(p => p._029tiposPersonalidad002materia)
                    .HasForeignKey(d => d._029tipoPersonalidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_029TiposPersonalidad_002Materias_029TiposPersonalidad");
            });

            modelBuilder.Entity<_030tiposTutor>(entity =>
            {
                entity.HasKey(e => e._030tipoTutorId);

                entity.ToTable("030TiposTutor");

                entity.Property(e => e._030tipoTutorId).HasColumnName("030TipoTutorId");

                entity.Property(e => e._030activo)
                    .IsRequired()
                    .HasColumnName("030Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._030nombre)
                    .IsRequired()
                    .HasColumnName("030Nombre");
            });

            modelBuilder.Entity<_031sistema>(entity =>
            {
                entity.ToTable("031Sistemas");

                entity.Property(e => e._031sistemaId)
                    .ValueGeneratedNever()
                    .HasColumnName("031SistemaId");

                entity.Property(e => e._025baseDeDatosId).HasColumnName("025BaseDeDatosId");

                entity.Property(e => e._031abreviatura)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("031Abreviatura");

                entity.Property(e => e._031activo)
                    .IsRequired()
                    .HasColumnName("031Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._031descripcion)
                    .IsRequired()
                    .HasColumnName("031Descripcion");

                entity.Property(e => e._031nombre)
                    .IsRequired()
                    .HasColumnName("031Nombre");

                entity.Property(e => e._031puedeModificarseSusPermisos).HasColumnName("031PuedeModificarseSusPermisos");

                entity.Property(e => e._031rutaDeAcceso).HasColumnName("031RutaDeAcceso");

                entity.Property(e => e._032tipoSistemaId).HasColumnName("032TipoSistemaId");

                entity.HasOne(d => d._025baseDeDatos)
                    .WithMany(p => p._031sistemas)
                    .HasForeignKey(d => d._025baseDeDatosId)
                    .HasConstraintName("FK_031Sistemas_025BasesDeDatos1");

                entity.HasOne(d => d._032tipoSistema)
                    .WithMany(p => p._031sistemas)
                    .HasForeignKey(d => d._032tipoSistemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_031Sistemas_032TiposSistema");
            });

            modelBuilder.Entity<_032tiposSistema>(entity =>
            {
                entity.HasKey(e => e._032tipoSistemaId);

                entity.ToTable("032TiposSistema");

                entity.Property(e => e._032tipoSistemaId).HasColumnName("032TipoSistemaId");

                entity.Property(e => e._032activo)
                    .IsRequired()
                    .HasColumnName("032Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._032icono)
                    .IsRequired()
                    .HasColumnName("032Icono");

                entity.Property(e => e._032nombre)
                    .IsRequired()
                    .HasColumnName("032Nombre");

                entity.Property(e => e._032rutaDeAcceso)
                    .IsRequired()
                    .HasColumnName("032RutaDeAcceso");
            });

            modelBuilder.Entity<_033tiposBienJuridico>(entity =>
            {
                entity.HasKey(e => e._033tipoBienJuridicoId)
                    .HasName("PK_TiposBienJuridico");

                entity.ToTable("033TiposBienJuridico");

                entity.Property(e => e._033tipoBienJuridicoId)
                    .ValueGeneratedNever()
                    .HasColumnName("033TipoBienJuridicoId");

                entity.Property(e => e._033activo)
                    .IsRequired()
                    .HasColumnName("033Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._033codigo)
                    .HasMaxLength(10)
                    .HasColumnName("033Codigo");

                entity.Property(e => e._033nombre)
                    .IsRequired()
                    .HasColumnName("033Nombre");
            });

            modelBuilder.Entity<_034tiposEvidencium>(entity =>
            {
                entity.HasKey(e => e._034tipoEvidenciaId);

                entity.ToTable("034TiposEvidencia");

                entity.Property(e => e._034tipoEvidenciaId).HasColumnName("034TipoEvidenciaId");

                entity.Property(e => e._034activo)
                    .IsRequired()
                    .HasColumnName("034Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._034nombre)
                    .IsRequired()
                    .HasColumnName("034Nombre");
            });

            modelBuilder.Entity<_035tiposRegistro>(entity =>
            {
                entity.HasKey(e => e._035tipoRegistroId)
                    .HasName("PK_TiposRegistro");

                entity.ToTable("035TiposRegistro");

                entity.Property(e => e._035tipoRegistroId).HasColumnName("035TipoRegistroId");

                entity.Property(e => e._035activo).HasColumnName("035Activo");

                entity.Property(e => e._035nombre)
                    .IsRequired()
                    .HasColumnName("035Nombre");
            });

            modelBuilder.Entity<_036tiposMovimiento>(entity =>
            {
                entity.HasKey(e => e._036tipoMovimientoId);

                entity.ToTable("036TiposMovimiento");

                entity.Property(e => e._036tipoMovimientoId).HasColumnName("036TipoMovimientoId");

                entity.Property(e => e._036activo).HasColumnName("036Activo");

                entity.Property(e => e._036nombre)
                    .IsRequired()
                    .HasColumnName("036Nombre");
            });

            modelBuilder.Entity<_037paise>(entity =>
            {
                entity.HasKey(e => e._037paisId);

                entity.ToTable("037Paises");

                entity.Property(e => e._037paisId).HasColumnName("037PaisId");

                entity.Property(e => e._037activo).HasColumnName("037Activo");

                entity.Property(e => e._037codigo)
                    .HasMaxLength(5)
                    .HasColumnName("037Codigo");

                entity.Property(e => e._037gentilicioFemenino).HasColumnName("037GentilicioFemenino");

                entity.Property(e => e._037gentilicioMasculino).HasColumnName("037GentilicioMasculino");

                entity.Property(e => e._037nombre)
                    .IsRequired()
                    .HasColumnName("037Nombre");
            });

            modelBuilder.Entity<_038tiposIdentificacion>(entity =>
            {
                entity.HasKey(e => e._038tipoIdentificacionId);

                entity.ToTable("038TiposIdentificacion");

                entity.Property(e => e._038tipoIdentificacionId)
                    .ValueGeneratedNever()
                    .HasColumnName("038TipoIdentificacionId");

                entity.Property(e => e._038activo)
                    .IsRequired()
                    .HasColumnName("038Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._038nombre)
                    .IsRequired()
                    .HasColumnName("038Nombre");
            });

            modelBuilder.Entity<_039tiposDepartamento>(entity =>
            {
                entity.HasKey(e => e._039tipoDepartamentoId);

                entity.ToTable("039TiposDepartamentos");

                entity.Property(e => e._039tipoDepartamentoId)
                    .ValueGeneratedNever()
                    .HasColumnName("039TipoDepartamentoId");

                entity.Property(e => e._039activo).HasColumnName("039Activo");

                entity.Property(e => e._039nombre)
                    .IsRequired()
                    .HasColumnName("039Nombre");
            });

            modelBuilder.Entity<_040tiposDepartamentosArea>(entity =>
            {
                entity.HasKey(e => e._040tipoDepartamentoAreaId)
                    .HasName("PK_039TiposDepartamentos_001Areas");

                entity.ToTable("040TiposDepartamentosAreas");

                entity.Property(e => e._040tipoDepartamentoAreaId)
                    .ValueGeneratedNever()
                    .HasColumnName("040TipoDepartamentoAreaId");

                entity.Property(e => e._001areaId).HasColumnName("001AreaId");

                entity.Property(e => e._039tipoDepartamentoId).HasColumnName("039TipoDepartamentoId");

                entity.HasOne(d => d._001area)
                    .WithMany(p => p._040tiposDepartamentosAreas)
                    .HasForeignKey(d => d._001areaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_040TiposDepartamentosAreas_001Areas");

                entity.HasOne(d => d._039tipoDepartamento)
                    .WithMany(p => p._040tiposDepartamentosAreas)
                    .HasForeignKey(d => d._039tipoDepartamentoId)
                    .HasConstraintName("FK_040TiposDepartamentosAreas_039TiposDepartamentos");
            });

            modelBuilder.Entity<_040tiposDepartamentosAreas045puesto>(entity =>
            {
                entity.HasKey(e => new { e._040tipoDepartamentoAreaId, e._045puestoId });

                entity.ToTable("040TiposDepartamentosAreas_045Puestos");

                entity.Property(e => e._040tipoDepartamentoAreaId).HasColumnName("040TipoDepartamentoAreaId");

                entity.Property(e => e._045puestoId).HasColumnName("045PuestoId");

                entity.HasOne(d => d._040tipoDepartamentoArea)
                    .WithMany(p => p._040tiposDepartamentosAreas045puestos)
                    .HasForeignKey(d => d._040tipoDepartamentoAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_040TiposDepartamentosAreas_045Puestos_040TiposDepartamentosAreas");

                entity.HasOne(d => d._045puesto)
                    .WithMany(p => p._040tiposDepartamentosAreas045puestos)
                    .HasForeignKey(d => d._045puestoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_040TiposDepartamentosAreas_045Puestos_045Puestos");
            });

            modelBuilder.Entity<_041tiposEstadoCivil>(entity =>
            {
                entity.HasKey(e => e._041tipoEstadoCivilId);

                entity.ToTable("041TiposEstadoCivil");

                entity.Property(e => e._041tipoEstadoCivilId).HasColumnName("041TipoEstadoCivilId");

                entity.Property(e => e._041activo).HasColumnName("041Activo");

                entity.Property(e => e._041nombre)
                    .IsRequired()
                    .HasColumnName("041Nombre");
            });

            modelBuilder.Entity<_042juicio>(entity =>
            {
                entity.ToTable("042Juicios");

                entity.Property(e => e._042juicioId)
                    .ValueGeneratedNever()
                    .HasColumnName("042JuicioId");

                entity.Property(e => e._002materiaId).HasColumnName("002MateriaId");

                entity.Property(e => e._042activo)
                    .IsRequired()
                    .HasColumnName("042Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._042naturaleza)
                    .HasMaxLength(5)
                    .HasColumnName("042Naturaleza");

                entity.Property(e => e._042nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("042Nombre");

                entity.Property(e => e._043colorCaratulaId).HasColumnName("043ColorCaratulaId");

                entity.HasOne(d => d._002materia)
                    .WithMany(p => p._042juicios)
                    .HasForeignKey(d => d._002materiaId)
                    .HasConstraintName("FK_042Juicios_002Materias");

                entity.HasOne(d => d._043colorCaratula)
                    .WithMany(p => p._042juicios)
                    .HasForeignKey(d => d._043colorCaratulaId)
                    .HasConstraintName("FK_042Juicios_043ColoresCaratula");
            });

            modelBuilder.Entity<_043coloresCaratula>(entity =>
            {
                entity.HasKey(e => e._043colorCaratulaId);

                entity.ToTable("043ColoresCaratula");

                entity.Property(e => e._043colorCaratulaId)
                    .ValueGeneratedNever()
                    .HasColumnName("043ColorCaratulaId");

                entity.Property(e => e._043fechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("043FechaInicio");

                entity.Property(e => e._043fechaTermino)
                    .HasColumnType("date")
                    .HasColumnName("043FechaTermino");

                entity.Property(e => e._043hexadecimal)
                    .HasMaxLength(6)
                    .HasColumnName("043Hexadecimal");

                entity.Property(e => e._043nombre)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasColumnName("043Nombre");
            });

            modelBuilder.Entity<_044tiposPuesto>(entity =>
            {
                entity.HasKey(e => e._044tipoPuestoId);

                entity.ToTable("044TiposPuestos");

                entity.Property(e => e._044tipoPuestoId).HasColumnName("044TipoPuestoId");

                entity.Property(e => e._044activo).HasColumnName("044Activo");

                entity.Property(e => e._044fechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("044FechaRegistro");

                entity.Property(e => e._044nombre)
                    .IsRequired()
                    .HasColumnName("044Nombre");

                entity.Property(e => e._044usuarioQuienRegistro001dbcuentas).HasColumnName("044UsuarioQuienRegistro_001DBCUENTAS");
            });

            modelBuilder.Entity<_045puesto>(entity =>
            {
                entity.ToTable("045Puestos");

                entity.Property(e => e._045puestoId).HasColumnName("045PuestoId");

                entity.Property(e => e._044tipoPuestoId).HasColumnName("044TipoPuestoId");

                entity.Property(e => e._045activo).HasColumnName("045Activo");

                entity.Property(e => e._045fechaFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("045FechaFinal");

                entity.Property(e => e._045fechaInicial)
                    .HasColumnType("datetime")
                    .HasColumnName("045FechaInicial");

                entity.Property(e => e._045fechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("045FechaRegistro");

                entity.Property(e => e._045muestraAutografa).HasColumnName("045MuestraAutografa");

                entity.Property(e => e._045nombre)
                    .IsRequired()
                    .HasColumnName("045Nombre");

                entity.Property(e => e._045usuarioQuienRegistro001dbcuentas).HasColumnName("045UsuarioQuienRegistro_001DBCUENTAS");

                entity.Property(e => e._052nivelPuestoId).HasColumnName("052NivelPuestoId");

                entity.Property(e => e._060tipoCategoriaPuestoId).HasColumnName("060TipoCategoriaPuestoId");

                entity.Property(e => e._068puestoOficialId).HasColumnName("068PuestoOficialId");

                entity.HasOne(d => d._044tipoPuesto)
                    .WithMany(p => p._045puestos)
                    .HasForeignKey(d => d._044tipoPuestoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_045Puestos_044TiposPuestos");

                entity.HasOne(d => d._052nivelPuesto)
                    .WithMany(p => p._045puestos)
                    .HasForeignKey(d => d._052nivelPuestoId)
                    .HasConstraintName("FK_045Puestos_052NivelesPuestos");

                entity.HasOne(d => d._060tipoCategoriaPuesto)
                    .WithMany(p => p._045puestos)
                    .HasForeignKey(d => d._060tipoCategoriaPuestoId)
                    .HasConstraintName("FK_045Puestos_060TipoCategoriaPuesto");

                entity.HasOne(d => d._068puestoOficial)
                    .WithMany(p => p._045puestos)
                    .HasForeignKey(d => d._068puestoOficialId)
                    .HasConstraintName("FK_045Puestos_068PuestosOficiales");
            });

            modelBuilder.Entity<_046tramite>(entity =>
            {
                entity.ToTable("046Tramites");

                entity.Property(e => e._046tramiteId)
                    .ValueGeneratedNever()
                    .HasColumnName("046TramiteId");

                entity.Property(e => e._042juicioId).HasColumnName("042JuicioId");

                entity.Property(e => e._046activo)
                    .IsRequired()
                    .HasColumnName("046Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._046asignacionDirecta5F).HasColumnName("046AsignacionDirecta5F");

                entity.Property(e => e._046asignacionDirecta6F).HasColumnName("046AsignacionDirecta6F");

                entity.Property(e => e._046nombre)
                    .IsRequired()
                    .HasMaxLength(130)
                    .HasColumnName("046Nombre");

                entity.Property(e => e._046tipoTramiteEquitasId021equitas)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("046TipoTramiteEquitasId_021EQUITAS");

                entity.Property(e => e._046tipoTramiteMajatIdDbmajat).HasColumnName("046TipoTramiteMajatId_DBMAJAT");

                entity.HasOne(d => d._042juicio)
                    .WithMany(p => p._046tramites)
                    .HasForeignKey(d => d._042juicioId)
                    .HasConstraintName("FK_046Tramites_042Juicios");
            });

            modelBuilder.Entity<_047tiposParentesco>(entity =>
            {
                entity.HasKey(e => e._047tipoParentescoId);

                entity.ToTable("047TiposParentesco");

                entity.Property(e => e._047tipoParentescoId).HasColumnName("047TipoParentescoId");

                entity.Property(e => e._047activo)
                    .IsRequired()
                    .HasColumnName("047Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._047nombre)
                    .IsRequired()
                    .HasColumnName("047Nombre");
            });

            modelBuilder.Entity<_048tiposFirmaElectronica>(entity =>
            {
                entity.HasKey(e => e._048tipoFirmaElectronicaId);

                entity.ToTable("048TiposFirmaElectronica");

                entity.Property(e => e._048tipoFirmaElectronicaId).HasColumnName("048TipoFirmaElectronicaId");

                entity.Property(e => e._048activo)
                    .IsRequired()
                    .HasColumnName("048Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._048nombre)
                    .IsRequired()
                    .HasColumnName("048Nombre");
            });

            modelBuilder.Entity<_049autoridadesFederale>(entity =>
            {
                entity.HasKey(e => e._049autoridadFederalId);

                entity.ToTable("049AutoridadesFederales");

                entity.Property(e => e._049autoridadFederalId).HasColumnName("049AutoridadFederalId");

                entity.Property(e => e._049activo)
                    .IsRequired()
                    .HasColumnName("049Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._049nombre)
                    .IsRequired()
                    .HasColumnName("049Nombre");

                entity.Property(e => e._050tipoAutoridadFederalId).HasColumnName("050TipoAutoridadFederalId");

                entity.HasOne(d => d._050tipoAutoridadFederal)
                    .WithMany(p => p._049autoridadesFederales)
                    .HasForeignKey(d => d._050tipoAutoridadFederalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_049AutoridadesFederales_050TiposAutoridadFederal");
            });

            modelBuilder.Entity<_050tiposAutoridadFederal>(entity =>
            {
                entity.HasKey(e => e._050tipoAutoridadFederalId)
                    .HasName("PK_050TiposAutoridadFederak");

                entity.ToTable("050TiposAutoridadFederal");

                entity.Property(e => e._050tipoAutoridadFederalId).HasColumnName("050TipoAutoridadFederalId");

                entity.Property(e => e._050activo)
                    .IsRequired()
                    .HasColumnName("050Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._050nombre)
                    .IsRequired()
                    .HasColumnName("050Nombre");
            });

            modelBuilder.Entity<_051anexo>(entity =>
            {
                entity.ToTable("051Anexos");

                entity.Property(e => e._051anexoId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("051AnexoId");

                entity.Property(e => e._051anexoIdEquitas)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("051AnexoId_Equitas");

                entity.Property(e => e._051nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("051Nombre");
            });

            modelBuilder.Entity<_052nivelesPuesto>(entity =>
            {
                entity.HasKey(e => e._052nivelPuestoId);

                entity.ToTable("052NivelesPuestos");

                entity.Property(e => e._052nivelPuestoId).HasColumnName("052NivelPuestoId");

                entity.Property(e => e._044usuarioQuienRegistro001dbcuentas).HasColumnName("044UsuarioQuienRegistro_001DBCUENTAS");

                entity.Property(e => e._052activo).HasColumnName("052Activo");

                entity.Property(e => e._052fechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("052FechaRegistro");

                entity.Property(e => e._052nombre)
                    .IsRequired()
                    .HasColumnName("052Nombre");
            });

            modelBuilder.Entity<_053articulo>(entity =>
            {
                entity.ToTable("053Articulos");

                entity.Property(e => e._053articuloId).HasColumnName("053ArticuloId");

                entity.Property(e => e._053activo)
                    .IsRequired()
                    .HasColumnName("053Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._053encabezado).HasColumnName("053Encabezado");

                entity.Property(e => e._053nombre)
                    .IsRequired()
                    .HasColumnName("053Nombre");

                entity.Property(e => e._053numero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("053Numero");

                entity.Property(e => e._053pie).HasColumnName("053Pie");
            });

            modelBuilder.Entity<_054fraccione>(entity =>
            {
                entity.HasKey(e => e._054fraccionId)
                    .HasName("PK_Fracciones");

                entity.ToTable("054Fracciones");

                entity.Property(e => e._054fraccionId).HasColumnName("054FraccionId");

                entity.Property(e => e._053articuloId).HasColumnName("053ArticuloId");

                entity.Property(e => e._054activo)
                    .IsRequired()
                    .HasColumnName("054Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._054descripcion).HasColumnName("054Descripcion");

                entity.Property(e => e._054nombre)
                    .IsRequired()
                    .HasColumnName("054Nombre");

                entity.Property(e => e._054numero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("054Numero");

                entity.Property(e => e._054numeroRomano)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("054NumeroRomano");

                entity.HasOne(d => d._053articulo)
                    .WithMany(p => p._054fracciones)
                    .HasForeignKey(d => d._053articuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_054Fracciones_053Articulos");
            });

            modelBuilder.Entity<_055inciso>(entity =>
            {
                entity.ToTable("055Incisos");

                entity.Property(e => e._055incisoId).HasColumnName("055IncisoId");

                entity.Property(e => e._054fraccionId).HasColumnName("054FraccionId");

                entity.Property(e => e._055activo)
                    .IsRequired()
                    .HasColumnName("055Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._055letraOnumero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("055LetraONumero");

                entity.Property(e => e._055nombre)
                    .IsRequired()
                    .HasColumnName("055Nombre");

                entity.HasOne(d => d._054fraccion)
                    .WithMany(p => p._055incisos)
                    .HasForeignKey(d => d._054fraccionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_055Incisos_054Fracciones");
            });

            modelBuilder.Entity<_057tiposIcono>(entity =>
            {
                entity.HasKey(e => e._057tipoIconoId);

                entity.ToTable("057TiposIconos");

                entity.Property(e => e._057tipoIconoId).HasColumnName("057TipoIconoId");

                entity.Property(e => e._057activo)
                    .IsRequired()
                    .HasColumnName("057Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._057icono)
                    .IsRequired()
                    .HasColumnName("057Icono");

                entity.Property(e => e._057usablePorUsuario).HasColumnName("057UsablePorUsuario");
            });

            modelBuilder.Entity<_058tiposTocasOrale>(entity =>
            {
                entity.HasKey(e => e._058tipoTocaOralId);

                entity.ToTable("058TiposTocasOrales");

                entity.Property(e => e._058tipoTocaOralId).HasColumnName("058TipoTocaOralId");

                entity.Property(e => e._058activo).HasColumnName("058Activo");

                entity.Property(e => e._058nombre)
                    .IsRequired()
                    .HasColumnName("058Nombre");
            });

            modelBuilder.Entity<_058tiposTocasOrales059tiposRecurso>(entity =>
            {
                entity.HasKey(e => new { e._058tipoTocaOralId, e._059tipoRecursoId });

                entity.ToTable("058TiposTocasOrales_059TiposRecursos");

                entity.Property(e => e._058tipoTocaOralId).HasColumnName("058TipoTocaOralId");

                entity.Property(e => e._059tipoRecursoId).HasColumnName("059TipoRecursoId");

                entity.HasOne(d => d._058tipoTocaOral)
                    .WithMany(p => p._058tiposTocasOrales059tiposRecursos)
                    .HasForeignKey(d => d._058tipoTocaOralId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_058TiposTocasOrales_059TiposRecursos_058TiposTocasOrales");

                entity.HasOne(d => d._059tipoRecurso)
                    .WithMany(p => p._058tiposTocasOrales059tiposRecursos)
                    .HasForeignKey(d => d._059tipoRecursoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_058TiposTocasOrales_059TiposRecursos_059TiposRecursos");
            });

            modelBuilder.Entity<_059tiposRecurso>(entity =>
            {
                entity.HasKey(e => e._059tipoRecursoId);

                entity.ToTable("059TiposRecursos");

                entity.Property(e => e._059tipoRecursoId).HasColumnName("059TipoRecursoId");

                entity.Property(e => e._059activo).HasColumnName("059Activo");

                entity.Property(e => e._059nombre)
                    .IsRequired()
                    .HasColumnName("059Nombre");
            });

            modelBuilder.Entity<_060tiposCategoriasPuesto>(entity =>
            {
                entity.HasKey(e => e._060tipoCategoriaPuestoId);

                entity.ToTable("060TiposCategoriasPuestos");

                entity.Property(e => e._060tipoCategoriaPuestoId).HasColumnName("060TipoCategoriaPuestoId");

                entity.Property(e => e._060activo).HasColumnName("060Activo");

                entity.Property(e => e._060fechaFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("060FechaFinal");

                entity.Property(e => e._060fechaInicial)
                    .HasColumnType("datetime")
                    .HasColumnName("060FechaInicial");

                entity.Property(e => e._060nombre)
                    .IsRequired()
                    .HasColumnName("060Nombre");
            });

            modelBuilder.Entity<_062tiposCorreosElectronico>(entity =>
            {
                entity.HasKey(e => e._062tipoCorreoElectronicoId);

                entity.ToTable("062TiposCorreosElectronicos");

                entity.Property(e => e._062tipoCorreoElectronicoId).HasColumnName("062TipoCorreoElectronicoId");

                entity.Property(e => e._062activo)
                    .IsRequired()
                    .HasColumnName("062Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._062nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("062Nombre");
            });

            modelBuilder.Entity<_063areasSistema>(entity =>
            {
                entity.HasKey(e => e._063areaSistemaId);

                entity.ToTable("063AreasSistemas");

                entity.Property(e => e._063areaSistemaId).HasColumnName("063AreaSistemaId");

                entity.Property(e => e._001areaId).HasColumnName("001AreaId");

                entity.Property(e => e._031sistemaId).HasColumnName("031SistemaId");

                entity.Property(e => e._063activo).HasColumnName("063Activo");

                entity.Property(e => e._063ordenArea).HasColumnName("063OrdenArea");

                entity.HasOne(d => d._001area)
                    .WithMany(p => p._063areasSistemas)
                    .HasForeignKey(d => d._001areaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_063AreasSistemas_001Areas");

                entity.HasOne(d => d._031sistema)
                    .WithMany(p => p._063areasSistemas)
                    .HasForeignKey(d => d._031sistemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_063AreasSistemas_031Sistemas");
            });

            modelBuilder.Entity<_064tiposClasificacionPerspectivaDeGenero>(entity =>
            {
                entity.HasKey(e => e._064tipoClasificacionPerspectivaDeGeneroId);

                entity.ToTable("064TiposClasificacionPerspectivaDeGenero");

                entity.Property(e => e._064tipoClasificacionPerspectivaDeGeneroId).HasColumnName("064TipoClasificacionPerspectivaDeGeneroId");

                entity.Property(e => e._064activo)
                    .IsRequired()
                    .HasColumnName("064Activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e._064nombre)
                    .IsRequired()
                    .HasColumnName("064Nombre");
            });

            modelBuilder.Entity<_065caracteristicasPerspectivaDeGenero>(entity =>
            {
                entity.HasKey(e => e._065caracteristicaPerspectivaDeGeneroId);

                entity.ToTable("065CaracteristicasPerspectivaDeGenero");

                entity.Property(e => e._065caracteristicaPerspectivaDeGeneroId).HasColumnName("065CaracteristicaPerspectivaDeGeneroId");

                entity.Property(e => e._064tipoClasificacionPerspectivaDeGeneroId).HasColumnName("064TipoClasificacionPerspectivaDeGeneroId");

                entity.Property(e => e._065activo).HasColumnName("065Activo");

                entity.Property(e => e._065nombre)
                    .IsRequired()
                    .HasColumnName("065Nombre");
            });

            modelBuilder.Entity<_066solicitudFirmaElectronicaMultiple>(entity =>
            {
                entity.HasKey(e => e._066multifirmaId);

                entity.ToTable("066SolicitudFirmaElectronicaMultiple");

                entity.Property(e => e._066multifirmaId).HasColumnName("066MultifirmaId");

                entity.Property(e => e._066areaId).HasColumnName("066AreaId");

                entity.Property(e => e._066descripcion).HasColumnName("066Descripcion");

                entity.Property(e => e._066fechaDeSolicitud)
                    .HasColumnType("datetime")
                    .HasColumnName("066FechaDeSolicitud");

                entity.Property(e => e._066rutaDeDocumentoAfirmar)
                    .IsRequired()
                    .HasColumnName("066RutaDeDocumentoAFirmar");

                entity.Property(e => e._066rutaDeDocumentoFirmado).HasColumnName("066RutaDeDocumentoFirmado");
            });

            modelBuilder.Entity<_067usuariosFirmaElectronicaMultiple>(entity =>
            {
                entity.HasKey(e => e._067usuarioId);

                entity.ToTable("067UsuariosFirmaElectronicaMultiple");

                entity.Property(e => e._067usuarioId).HasColumnName("067UsuarioId");

                entity.Property(e => e._066multifirmaId).HasColumnName("066MultifirmaId");

                entity.Property(e => e._067areaDeUsarioId).HasColumnName("067AreaDeUsarioId");

                entity.Property(e => e._067fechaEnQueFirmo)
                    .HasColumnType("datetime")
                    .HasColumnName("067FechaEnQueFirmo");

                entity.Property(e => e._067nombre)
                    .IsRequired()
                    .HasColumnName("067Nombre");

                entity.Property(e => e._067rutaCertificadoPem).HasColumnName("067RutaCertificadoPEM");

                entity.Property(e => e._067rutaLlavePrivadaPem).HasColumnName("067RutaLLavePrivadaPEM");

                entity.Property(e => e._067usuarioId001dbcuentas).HasColumnName("067UsuarioId_001DBCuentas");

                entity.HasOne(d => d._066multifirma)
                    .WithMany(p => p._067usuariosFirmaElectronicaMultiples)
                    .HasForeignKey(d => d._066multifirmaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_067UsuariosFirmaElectronicaMultiple_066SolicitudFirmaElectronicaMultiple");
            });

            modelBuilder.Entity<_068puestosOficiale>(entity =>
            {
                entity.HasKey(e => e._068puestoOficialId)
                    .HasName("PK_066PuestoOficial");

                entity.ToTable("068PuestosOficiales");

                entity.Property(e => e._068puestoOficialId)
                    .ValueGeneratedNever()
                    .HasColumnName("068PuestoOficialId");

                entity.Property(e => e._060tipoCategoriaPuestoId).HasColumnName("060TipoCategoriaPuestoId");

                entity.Property(e => e._068activo).HasColumnName("068Activo");

                entity.Property(e => e._068clave)
                    .HasMaxLength(10)
                    .HasColumnName("068Clave");

                entity.Property(e => e._068nombre)
                    .IsRequired()
                    .HasColumnName("068Nombre");

                entity.HasOne(d => d._060tipoCategoriaPuesto)
                    .WithMany(p => p._068puestosOficiales)
                    .HasForeignKey(d => d._060tipoCategoriaPuestoId)
                    .HasConstraintName("FK_068PuestoOficial_060TiposCategoriasPuestos");
            });

            modelBuilder.Entity<_069tipoResolucion>(entity =>
            {
                entity.HasKey(e => e.TipoResolucionId);

                entity.ToTable("069TipoResolucion");

                entity.Property(e => e.TipoResolucionId).HasColumnName("TipoResolucionID");

                entity.Property(e => e.ActivoSicpe).HasColumnName("ActivoSICPE");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.TipoResolucionIdMajat).HasColumnName("TipoResolucionID_Majat");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
