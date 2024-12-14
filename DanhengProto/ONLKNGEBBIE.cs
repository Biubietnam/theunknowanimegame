using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C67 RID: 3175
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ONLKNGEBBIE : IMessage<ONLKNGEBBIE>, IMessage, IEquatable<ONLKNGEBBIE>, IDeepCloneable<ONLKNGEBBIE>, IBufferMessage
	{
		// Token: 0x1700279E RID: 10142
		// (get) Token: 0x06008D0B RID: 36107 RVA: 0x00174C6D File Offset: 0x00172E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ONLKNGEBBIE> Parser
		{
			get
			{
				return ONLKNGEBBIE._parser;
			}
		}

		// Token: 0x1700279F RID: 10143
		// (get) Token: 0x06008D0C RID: 36108 RVA: 0x00174C74 File Offset: 0x00172E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ONLKNGEBBIEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170027A0 RID: 10144
		// (get) Token: 0x06008D0D RID: 36109 RVA: 0x00174C86 File Offset: 0x00172E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ONLKNGEBBIE.Descriptor;
			}
		}

		// Token: 0x06008D0E RID: 36110 RVA: 0x00174C8D File Offset: 0x00172E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ONLKNGEBBIE()
		{
		}

		// Token: 0x06008D0F RID: 36111 RVA: 0x00174C98 File Offset: 0x00172E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ONLKNGEBBIE(ONLKNGEBBIE other) : this()
		{
			this.fICGHOPLNJO_ = other.fICGHOPLNJO_;
			this.isTakenReward_ = other.isTakenReward_;
			this.nCEJNFFMGGF_ = other.nCEJNFFMGGF_;
			this.panelId_ = other.panelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D10 RID: 36112 RVA: 0x00174CEC File Offset: 0x00172EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ONLKNGEBBIE Clone()
		{
			return new ONLKNGEBBIE(this);
		}

		// Token: 0x170027A1 RID: 10145
		// (get) Token: 0x06008D11 RID: 36113 RVA: 0x00174CF4 File Offset: 0x00172EF4
		// (set) Token: 0x06008D12 RID: 36114 RVA: 0x00174CFC File Offset: 0x00172EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FICGHOPLNJO
		{
			get
			{
				return this.fICGHOPLNJO_;
			}
			set
			{
				this.fICGHOPLNJO_ = value;
			}
		}

		// Token: 0x170027A2 RID: 10146
		// (get) Token: 0x06008D13 RID: 36115 RVA: 0x00174D05 File Offset: 0x00172F05
		// (set) Token: 0x06008D14 RID: 36116 RVA: 0x00174D0D File Offset: 0x00172F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTakenReward
		{
			get
			{
				return this.isTakenReward_;
			}
			set
			{
				this.isTakenReward_ = value;
			}
		}

		// Token: 0x170027A3 RID: 10147
		// (get) Token: 0x06008D15 RID: 36117 RVA: 0x00174D16 File Offset: 0x00172F16
		// (set) Token: 0x06008D16 RID: 36118 RVA: 0x00174D1E File Offset: 0x00172F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NCEJNFFMGGF
		{
			get
			{
				return this.nCEJNFFMGGF_;
			}
			set
			{
				this.nCEJNFFMGGF_ = value;
			}
		}

		// Token: 0x170027A4 RID: 10148
		// (get) Token: 0x06008D17 RID: 36119 RVA: 0x00174D27 File Offset: 0x00172F27
		// (set) Token: 0x06008D18 RID: 36120 RVA: 0x00174D2F File Offset: 0x00172F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PanelId
		{
			get
			{
				return this.panelId_;
			}
			set
			{
				this.panelId_ = value;
			}
		}

		// Token: 0x06008D19 RID: 36121 RVA: 0x00174D38 File Offset: 0x00172F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ONLKNGEBBIE);
		}

		// Token: 0x06008D1A RID: 36122 RVA: 0x00174D48 File Offset: 0x00172F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ONLKNGEBBIE other)
		{
			return other != null && (other == this || (this.FICGHOPLNJO == other.FICGHOPLNJO && this.IsTakenReward == other.IsTakenReward && this.NCEJNFFMGGF == other.NCEJNFFMGGF && this.PanelId == other.PanelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D1B RID: 36123 RVA: 0x00174DB4 File Offset: 0x00172FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FICGHOPLNJO)
			{
				num ^= this.FICGHOPLNJO.GetHashCode();
			}
			if (this.IsTakenReward)
			{
				num ^= this.IsTakenReward.GetHashCode();
			}
			if (this.NCEJNFFMGGF != 0U)
			{
				num ^= this.NCEJNFFMGGF.GetHashCode();
			}
			if (this.PanelId != 0U)
			{
				num ^= this.PanelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D1C RID: 36124 RVA: 0x00174E3E File Offset: 0x0017303E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008D1D RID: 36125 RVA: 0x00174E46 File Offset: 0x00173046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D1E RID: 36126 RVA: 0x00174E50 File Offset: 0x00173050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FICGHOPLNJO)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.FICGHOPLNJO);
			}
			if (this.IsTakenReward)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsTakenReward);
			}
			if (this.PanelId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.PanelId);
			}
			if (this.NCEJNFFMGGF != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.NCEJNFFMGGF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D1F RID: 36127 RVA: 0x00174EE4 File Offset: 0x001730E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FICGHOPLNJO)
			{
				num += 2;
			}
			if (this.IsTakenReward)
			{
				num += 2;
			}
			if (this.NCEJNFFMGGF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NCEJNFFMGGF);
			}
			if (this.PanelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PanelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D20 RID: 36128 RVA: 0x00174F54 File Offset: 0x00173154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ONLKNGEBBIE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FICGHOPLNJO)
			{
				this.FICGHOPLNJO = other.FICGHOPLNJO;
			}
			if (other.IsTakenReward)
			{
				this.IsTakenReward = other.IsTakenReward;
			}
			if (other.NCEJNFFMGGF != 0U)
			{
				this.NCEJNFFMGGF = other.NCEJNFFMGGF;
			}
			if (other.PanelId != 0U)
			{
				this.PanelId = other.PanelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008D21 RID: 36129 RVA: 0x00174FCC File Offset: 0x001731CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D22 RID: 36130 RVA: 0x00174FD8 File Offset: 0x001731D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 56U)
					{
						this.FICGHOPLNJO = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.IsTakenReward = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.PanelId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.NCEJNFFMGGF = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003629 RID: 13865
		private static readonly MessageParser<ONLKNGEBBIE> _parser = new MessageParser<ONLKNGEBBIE>(() => new ONLKNGEBBIE());

		// Token: 0x0400362A RID: 13866
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400362B RID: 13867
		public const int FICGHOPLNJOFieldNumber = 7;

		// Token: 0x0400362C RID: 13868
		private bool fICGHOPLNJO_;

		// Token: 0x0400362D RID: 13869
		public const int IsTakenRewardFieldNumber = 8;

		// Token: 0x0400362E RID: 13870
		private bool isTakenReward_;

		// Token: 0x0400362F RID: 13871
		public const int NCEJNFFMGGFFieldNumber = 15;

		// Token: 0x04003630 RID: 13872
		private uint nCEJNFFMGGF_;

		// Token: 0x04003631 RID: 13873
		public const int PanelIdFieldNumber = 10;

		// Token: 0x04003632 RID: 13874
		private uint panelId_;
	}
}
