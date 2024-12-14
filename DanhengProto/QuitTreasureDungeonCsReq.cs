using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D57 RID: 3415
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuitTreasureDungeonCsReq : IMessage<QuitTreasureDungeonCsReq>, IMessage, IEquatable<QuitTreasureDungeonCsReq>, IDeepCloneable<QuitTreasureDungeonCsReq>, IBufferMessage
	{
		// Token: 0x17002B12 RID: 11026
		// (get) Token: 0x06009898 RID: 39064 RVA: 0x00196779 File Offset: 0x00194979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuitTreasureDungeonCsReq> Parser
		{
			get
			{
				return QuitTreasureDungeonCsReq._parser;
			}
		}

		// Token: 0x17002B13 RID: 11027
		// (get) Token: 0x06009899 RID: 39065 RVA: 0x00196780 File Offset: 0x00194980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuitTreasureDungeonCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B14 RID: 11028
		// (get) Token: 0x0600989A RID: 39066 RVA: 0x00196792 File Offset: 0x00194992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuitTreasureDungeonCsReq.Descriptor;
			}
		}

		// Token: 0x0600989B RID: 39067 RVA: 0x00196799 File Offset: 0x00194999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitTreasureDungeonCsReq()
		{
		}

		// Token: 0x0600989C RID: 39068 RVA: 0x001967A1 File Offset: 0x001949A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitTreasureDungeonCsReq(QuitTreasureDungeonCsReq other) : this()
		{
			this.nCFAJPAMBGD_ = other.nCFAJPAMBGD_;
			this.lCDLBENJGIO_ = other.lCDLBENJGIO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600989D RID: 39069 RVA: 0x001967D2 File Offset: 0x001949D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitTreasureDungeonCsReq Clone()
		{
			return new QuitTreasureDungeonCsReq(this);
		}

		// Token: 0x17002B15 RID: 11029
		// (get) Token: 0x0600989E RID: 39070 RVA: 0x001967DA File Offset: 0x001949DA
		// (set) Token: 0x0600989F RID: 39071 RVA: 0x001967E2 File Offset: 0x001949E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NCFAJPAMBGD
		{
			get
			{
				return this.nCFAJPAMBGD_;
			}
			set
			{
				this.nCFAJPAMBGD_ = value;
			}
		}

		// Token: 0x17002B16 RID: 11030
		// (get) Token: 0x060098A0 RID: 39072 RVA: 0x001967EB File Offset: 0x001949EB
		// (set) Token: 0x060098A1 RID: 39073 RVA: 0x001967F3 File Offset: 0x001949F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LCDLBENJGIO
		{
			get
			{
				return this.lCDLBENJGIO_;
			}
			set
			{
				this.lCDLBENJGIO_ = value;
			}
		}

		// Token: 0x060098A2 RID: 39074 RVA: 0x001967FC File Offset: 0x001949FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuitTreasureDungeonCsReq);
		}

		// Token: 0x060098A3 RID: 39075 RVA: 0x0019680A File Offset: 0x00194A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuitTreasureDungeonCsReq other)
		{
			return other != null && (other == this || (this.NCFAJPAMBGD == other.NCFAJPAMBGD && this.LCDLBENJGIO == other.LCDLBENJGIO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060098A4 RID: 39076 RVA: 0x00196848 File Offset: 0x00194A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NCFAJPAMBGD != 0U)
			{
				num ^= this.NCFAJPAMBGD.GetHashCode();
			}
			if (this.LCDLBENJGIO)
			{
				num ^= this.LCDLBENJGIO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060098A5 RID: 39077 RVA: 0x001968A0 File Offset: 0x00194AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060098A6 RID: 39078 RVA: 0x001968A8 File Offset: 0x00194AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098A7 RID: 39079 RVA: 0x001968B4 File Offset: 0x00194AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NCFAJPAMBGD != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.NCFAJPAMBGD);
			}
			if (this.LCDLBENJGIO)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.LCDLBENJGIO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060098A8 RID: 39080 RVA: 0x00196910 File Offset: 0x00194B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NCFAJPAMBGD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NCFAJPAMBGD);
			}
			if (this.LCDLBENJGIO)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060098A9 RID: 39081 RVA: 0x0019695C File Offset: 0x00194B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuitTreasureDungeonCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NCFAJPAMBGD != 0U)
			{
				this.NCFAJPAMBGD = other.NCFAJPAMBGD;
			}
			if (other.LCDLBENJGIO)
			{
				this.LCDLBENJGIO = other.LCDLBENJGIO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060098AA RID: 39082 RVA: 0x001969AC File Offset: 0x00194BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098AB RID: 39083 RVA: 0x001969B8 File Offset: 0x00194BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LCDLBENJGIO = input.ReadBool();
					}
				}
				else
				{
					this.NCFAJPAMBGD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003B4D RID: 15181
		private static readonly MessageParser<QuitTreasureDungeonCsReq> _parser = new MessageParser<QuitTreasureDungeonCsReq>(() => new QuitTreasureDungeonCsReq());

		// Token: 0x04003B4E RID: 15182
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B4F RID: 15183
		public const int NCFAJPAMBGDFieldNumber = 6;

		// Token: 0x04003B50 RID: 15184
		private uint nCFAJPAMBGD_;

		// Token: 0x04003B51 RID: 15185
		public const int LCDLBENJGIOFieldNumber = 14;

		// Token: 0x04003B52 RID: 15186
		private bool lCDLBENJGIO_;
	}
}
