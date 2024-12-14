using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E45 RID: 3653
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonDialogueInfo : IMessage<RogueCommonDialogueInfo>, IMessage, IEquatable<RogueCommonDialogueInfo>, IDeepCloneable<RogueCommonDialogueInfo>, IBufferMessage
	{
		// Token: 0x17002E04 RID: 11780
		// (get) Token: 0x0600A2ED RID: 41709 RVA: 0x001B640E File Offset: 0x001B460E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonDialogueInfo> Parser
		{
			get
			{
				return RogueCommonDialogueInfo._parser;
			}
		}

		// Token: 0x17002E05 RID: 11781
		// (get) Token: 0x0600A2EE RID: 41710 RVA: 0x001B6415 File Offset: 0x001B4615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonDialogueInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E06 RID: 11782
		// (get) Token: 0x0600A2EF RID: 41711 RVA: 0x001B6427 File Offset: 0x001B4627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonDialogueInfo.Descriptor;
			}
		}

		// Token: 0x0600A2F0 RID: 41712 RVA: 0x001B642E File Offset: 0x001B462E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueInfo()
		{
		}

		// Token: 0x0600A2F1 RID: 41713 RVA: 0x001B6438 File Offset: 0x001B4638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueInfo(RogueCommonDialogueInfo other) : this()
		{
			this.dialogueBasicInfo_ = ((other.dialogueBasicInfo_ != null) ? other.dialogueBasicInfo_.Clone() : null);
			this.nJGKKOGFPBL_ = ((other.nJGKKOGFPBL_ != null) ? other.nJGKKOGFPBL_.Clone() : null);
			this.eFIMOAOLJNE_ = ((other.eFIMOAOLJNE_ != null) ? other.eFIMOAOLJNE_.Clone() : null);
			this.jOMHNGOAOIO_ = ((other.jOMHNGOAOIO_ != null) ? other.jOMHNGOAOIO_.Clone() : null);
			this.jDMGJDBMHEJ_ = ((other.jDMGJDBMHEJ_ != null) ? other.jDMGJDBMHEJ_.Clone() : null);
			this.cGEKHIPJCAJ_ = ((other.cGEKHIPJCAJ_ != null) ? other.cGEKHIPJCAJ_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2F2 RID: 41714 RVA: 0x001B6504 File Offset: 0x001B4704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueInfo Clone()
		{
			return new RogueCommonDialogueInfo(this);
		}

		// Token: 0x17002E07 RID: 11783
		// (get) Token: 0x0600A2F3 RID: 41715 RVA: 0x001B650C File Offset: 0x001B470C
		// (set) Token: 0x0600A2F4 RID: 41716 RVA: 0x001B6514 File Offset: 0x001B4714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueBasicInfo DialogueBasicInfo
		{
			get
			{
				return this.dialogueBasicInfo_;
			}
			set
			{
				this.dialogueBasicInfo_ = value;
			}
		}

		// Token: 0x17002E08 RID: 11784
		// (get) Token: 0x0600A2F5 RID: 41717 RVA: 0x001B651D File Offset: 0x001B471D
		// (set) Token: 0x0600A2F6 RID: 41718 RVA: 0x001B6525 File Offset: 0x001B4725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FPNMFAMBIIL NJGKKOGFPBL
		{
			get
			{
				return this.nJGKKOGFPBL_;
			}
			set
			{
				this.nJGKKOGFPBL_ = value;
			}
		}

		// Token: 0x17002E09 RID: 11785
		// (get) Token: 0x0600A2F7 RID: 41719 RVA: 0x001B652E File Offset: 0x001B472E
		// (set) Token: 0x0600A2F8 RID: 41720 RVA: 0x001B6536 File Offset: 0x001B4736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NMIMOEMLFGP EFIMOAOLJNE
		{
			get
			{
				return this.eFIMOAOLJNE_;
			}
			set
			{
				this.eFIMOAOLJNE_ = value;
			}
		}

		// Token: 0x17002E0A RID: 11786
		// (get) Token: 0x0600A2F9 RID: 41721 RVA: 0x001B653F File Offset: 0x001B473F
		// (set) Token: 0x0600A2FA RID: 41722 RVA: 0x001B6547 File Offset: 0x001B4747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MNCJPNFJLBC JOMHNGOAOIO
		{
			get
			{
				return this.jOMHNGOAOIO_;
			}
			set
			{
				this.jOMHNGOAOIO_ = value;
			}
		}

		// Token: 0x17002E0B RID: 11787
		// (get) Token: 0x0600A2FB RID: 41723 RVA: 0x001B6550 File Offset: 0x001B4750
		// (set) Token: 0x0600A2FC RID: 41724 RVA: 0x001B6558 File Offset: 0x001B4758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENOIDDNBAEP JDMGJDBMHEJ
		{
			get
			{
				return this.jDMGJDBMHEJ_;
			}
			set
			{
				this.jDMGJDBMHEJ_ = value;
			}
		}

		// Token: 0x17002E0C RID: 11788
		// (get) Token: 0x0600A2FD RID: 41725 RVA: 0x001B6561 File Offset: 0x001B4761
		// (set) Token: 0x0600A2FE RID: 41726 RVA: 0x001B6569 File Offset: 0x001B4769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JLENPNKJOJD CGEKHIPJCAJ
		{
			get
			{
				return this.cGEKHIPJCAJ_;
			}
			set
			{
				this.cGEKHIPJCAJ_ = value;
			}
		}

		// Token: 0x0600A2FF RID: 41727 RVA: 0x001B6572 File Offset: 0x001B4772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonDialogueInfo);
		}

		// Token: 0x0600A300 RID: 41728 RVA: 0x001B6580 File Offset: 0x001B4780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonDialogueInfo other)
		{
			return other != null && (other == this || (object.Equals(this.DialogueBasicInfo, other.DialogueBasicInfo) && object.Equals(this.NJGKKOGFPBL, other.NJGKKOGFPBL) && object.Equals(this.EFIMOAOLJNE, other.EFIMOAOLJNE) && object.Equals(this.JOMHNGOAOIO, other.JOMHNGOAOIO) && object.Equals(this.JDMGJDBMHEJ, other.JDMGJDBMHEJ) && object.Equals(this.CGEKHIPJCAJ, other.CGEKHIPJCAJ) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A301 RID: 41729 RVA: 0x001B6628 File Offset: 0x001B4828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dialogueBasicInfo_ != null)
			{
				num ^= this.DialogueBasicInfo.GetHashCode();
			}
			if (this.nJGKKOGFPBL_ != null)
			{
				num ^= this.NJGKKOGFPBL.GetHashCode();
			}
			if (this.eFIMOAOLJNE_ != null)
			{
				num ^= this.EFIMOAOLJNE.GetHashCode();
			}
			if (this.jOMHNGOAOIO_ != null)
			{
				num ^= this.JOMHNGOAOIO.GetHashCode();
			}
			if (this.jDMGJDBMHEJ_ != null)
			{
				num ^= this.JDMGJDBMHEJ.GetHashCode();
			}
			if (this.cGEKHIPJCAJ_ != null)
			{
				num ^= this.CGEKHIPJCAJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A302 RID: 41730 RVA: 0x001B66D2 File Offset: 0x001B48D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A303 RID: 41731 RVA: 0x001B66DA File Offset: 0x001B48DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A304 RID: 41732 RVA: 0x001B66E4 File Offset: 0x001B48E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.nJGKKOGFPBL_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.NJGKKOGFPBL);
			}
			if (this.dialogueBasicInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.DialogueBasicInfo);
			}
			if (this.eFIMOAOLJNE_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.EFIMOAOLJNE);
			}
			if (this.cGEKHIPJCAJ_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.CGEKHIPJCAJ);
			}
			if (this.jDMGJDBMHEJ_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.JDMGJDBMHEJ);
			}
			if (this.jOMHNGOAOIO_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.JOMHNGOAOIO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x001B67B0 File Offset: 0x001B49B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dialogueBasicInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DialogueBasicInfo);
			}
			if (this.nJGKKOGFPBL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NJGKKOGFPBL);
			}
			if (this.eFIMOAOLJNE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EFIMOAOLJNE);
			}
			if (this.jOMHNGOAOIO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JOMHNGOAOIO);
			}
			if (this.jDMGJDBMHEJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JDMGJDBMHEJ);
			}
			if (this.cGEKHIPJCAJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CGEKHIPJCAJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A306 RID: 41734 RVA: 0x001B6868 File Offset: 0x001B4A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonDialogueInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.dialogueBasicInfo_ != null)
			{
				if (this.dialogueBasicInfo_ == null)
				{
					this.DialogueBasicInfo = new RogueCommonDialogueBasicInfo();
				}
				this.DialogueBasicInfo.MergeFrom(other.DialogueBasicInfo);
			}
			if (other.nJGKKOGFPBL_ != null)
			{
				if (this.nJGKKOGFPBL_ == null)
				{
					this.NJGKKOGFPBL = new FPNMFAMBIIL();
				}
				this.NJGKKOGFPBL.MergeFrom(other.NJGKKOGFPBL);
			}
			if (other.eFIMOAOLJNE_ != null)
			{
				if (this.eFIMOAOLJNE_ == null)
				{
					this.EFIMOAOLJNE = new NMIMOEMLFGP();
				}
				this.EFIMOAOLJNE.MergeFrom(other.EFIMOAOLJNE);
			}
			if (other.jOMHNGOAOIO_ != null)
			{
				if (this.jOMHNGOAOIO_ == null)
				{
					this.JOMHNGOAOIO = new MNCJPNFJLBC();
				}
				this.JOMHNGOAOIO.MergeFrom(other.JOMHNGOAOIO);
			}
			if (other.jDMGJDBMHEJ_ != null)
			{
				if (this.jDMGJDBMHEJ_ == null)
				{
					this.JDMGJDBMHEJ = new ENOIDDNBAEP();
				}
				this.JDMGJDBMHEJ.MergeFrom(other.JDMGJDBMHEJ);
			}
			if (other.cGEKHIPJCAJ_ != null)
			{
				if (this.cGEKHIPJCAJ_ == null)
				{
					this.CGEKHIPJCAJ = new JLENPNKJOJD();
				}
				this.CGEKHIPJCAJ.MergeFrom(other.CGEKHIPJCAJ);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A307 RID: 41735 RVA: 0x001B6998 File Offset: 0x001B4B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A308 RID: 41736 RVA: 0x001B69A4 File Offset: 0x001B4BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num == 10U)
					{
						if (this.nJGKKOGFPBL_ == null)
						{
							this.NJGKKOGFPBL = new FPNMFAMBIIL();
						}
						input.ReadMessage(this.NJGKKOGFPBL);
						continue;
					}
					if (num == 18U)
					{
						if (this.dialogueBasicInfo_ == null)
						{
							this.DialogueBasicInfo = new RogueCommonDialogueBasicInfo();
						}
						input.ReadMessage(this.DialogueBasicInfo);
						continue;
					}
					if (num == 34U)
					{
						if (this.eFIMOAOLJNE_ == null)
						{
							this.EFIMOAOLJNE = new NMIMOEMLFGP();
						}
						input.ReadMessage(this.EFIMOAOLJNE);
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						if (this.cGEKHIPJCAJ_ == null)
						{
							this.CGEKHIPJCAJ = new JLENPNKJOJD();
						}
						input.ReadMessage(this.CGEKHIPJCAJ);
						continue;
					}
					if (num == 90U)
					{
						if (this.jDMGJDBMHEJ_ == null)
						{
							this.JDMGJDBMHEJ = new ENOIDDNBAEP();
						}
						input.ReadMessage(this.JDMGJDBMHEJ);
						continue;
					}
					if (num == 114U)
					{
						if (this.jOMHNGOAOIO_ == null)
						{
							this.JOMHNGOAOIO = new MNCJPNFJLBC();
						}
						input.ReadMessage(this.JOMHNGOAOIO);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040042BD RID: 17085
		private static readonly MessageParser<RogueCommonDialogueInfo> _parser = new MessageParser<RogueCommonDialogueInfo>(() => new RogueCommonDialogueInfo());

		// Token: 0x040042BE RID: 17086
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042BF RID: 17087
		public const int DialogueBasicInfoFieldNumber = 2;

		// Token: 0x040042C0 RID: 17088
		private RogueCommonDialogueBasicInfo dialogueBasicInfo_;

		// Token: 0x040042C1 RID: 17089
		public const int NJGKKOGFPBLFieldNumber = 1;

		// Token: 0x040042C2 RID: 17090
		private FPNMFAMBIIL nJGKKOGFPBL_;

		// Token: 0x040042C3 RID: 17091
		public const int EFIMOAOLJNEFieldNumber = 4;

		// Token: 0x040042C4 RID: 17092
		private NMIMOEMLFGP eFIMOAOLJNE_;

		// Token: 0x040042C5 RID: 17093
		public const int JOMHNGOAOIOFieldNumber = 14;

		// Token: 0x040042C6 RID: 17094
		private MNCJPNFJLBC jOMHNGOAOIO_;

		// Token: 0x040042C7 RID: 17095
		public const int JDMGJDBMHEJFieldNumber = 11;

		// Token: 0x040042C8 RID: 17096
		private ENOIDDNBAEP jDMGJDBMHEJ_;

		// Token: 0x040042C9 RID: 17097
		public const int CGEKHIPJCAJFieldNumber = 7;

		// Token: 0x040042CA RID: 17098
		private JLENPNKJOJD cGEKHIPJCAJ_;
	}
}
