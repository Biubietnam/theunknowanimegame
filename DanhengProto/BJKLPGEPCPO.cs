using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000125 RID: 293
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BJKLPGEPCPO : IMessage<BJKLPGEPCPO>, IMessage, IEquatable<BJKLPGEPCPO>, IDeepCloneable<BJKLPGEPCPO>, IBufferMessage
	{
		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x00027A11 File Offset: 0x00025C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BJKLPGEPCPO> Parser
		{
			get
			{
				return BJKLPGEPCPO._parser;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x00027A18 File Offset: 0x00025C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BJKLPGEPCPOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x00027A2A File Offset: 0x00025C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BJKLPGEPCPO.Descriptor;
			}
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00027A31 File Offset: 0x00025C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BJKLPGEPCPO()
		{
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00027A3C File Offset: 0x00025C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BJKLPGEPCPO(BJKLPGEPCPO other) : this()
		{
			this.eICILFAIAEE_ = other.eICILFAIAEE_;
			this.oHKNLLIHDGJ_ = other.oHKNLLIHDGJ_;
			this.pBHFELEJFHJ_ = other.pBHFELEJFHJ_;
			this.panelId_ = other.panelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00027A90 File Offset: 0x00025C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BJKLPGEPCPO Clone()
		{
			return new BJKLPGEPCPO(this);
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x00027A98 File Offset: 0x00025C98
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x00027AA0 File Offset: 0x00025CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EICILFAIAEE
		{
			get
			{
				return this.eICILFAIAEE_;
			}
			set
			{
				this.eICILFAIAEE_ = value;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00027AA9 File Offset: 0x00025CA9
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x00027AB1 File Offset: 0x00025CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OHKNLLIHDGJ
		{
			get
			{
				return this.oHKNLLIHDGJ_;
			}
			set
			{
				this.oHKNLLIHDGJ_ = value;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x00027ABA File Offset: 0x00025CBA
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x00027AC2 File Offset: 0x00025CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PBHFELEJFHJ
		{
			get
			{
				return this.pBHFELEJFHJ_;
			}
			set
			{
				this.pBHFELEJFHJ_ = value;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x00027ACB File Offset: 0x00025CCB
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x00027AD3 File Offset: 0x00025CD3
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

		// Token: 0x06000D42 RID: 3394 RVA: 0x00027ADC File Offset: 0x00025CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BJKLPGEPCPO);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00027AEC File Offset: 0x00025CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BJKLPGEPCPO other)
		{
			return other != null && (other == this || (this.EICILFAIAEE == other.EICILFAIAEE && this.OHKNLLIHDGJ == other.OHKNLLIHDGJ && this.PBHFELEJFHJ == other.PBHFELEJFHJ && this.PanelId == other.PanelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00027B58 File Offset: 0x00025D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EICILFAIAEE != 0U)
			{
				num ^= this.EICILFAIAEE.GetHashCode();
			}
			if (this.OHKNLLIHDGJ != 0U)
			{
				num ^= this.OHKNLLIHDGJ.GetHashCode();
			}
			if (this.PBHFELEJFHJ != 0U)
			{
				num ^= this.PBHFELEJFHJ.GetHashCode();
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

		// Token: 0x06000D45 RID: 3397 RVA: 0x00027BE2 File Offset: 0x00025DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00027BEA File Offset: 0x00025DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00027BF4 File Offset: 0x00025DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EICILFAIAEE != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.EICILFAIAEE);
			}
			if (this.PBHFELEJFHJ != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.PBHFELEJFHJ);
			}
			if (this.OHKNLLIHDGJ != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.OHKNLLIHDGJ);
			}
			if (this.PanelId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.PanelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00027C88 File Offset: 0x00025E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EICILFAIAEE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EICILFAIAEE);
			}
			if (this.OHKNLLIHDGJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OHKNLLIHDGJ);
			}
			if (this.PBHFELEJFHJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PBHFELEJFHJ);
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

		// Token: 0x06000D49 RID: 3401 RVA: 0x00027D10 File Offset: 0x00025F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BJKLPGEPCPO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EICILFAIAEE != 0U)
			{
				this.EICILFAIAEE = other.EICILFAIAEE;
			}
			if (other.OHKNLLIHDGJ != 0U)
			{
				this.OHKNLLIHDGJ = other.OHKNLLIHDGJ;
			}
			if (other.PBHFELEJFHJ != 0U)
			{
				this.PBHFELEJFHJ = other.PBHFELEJFHJ;
			}
			if (other.PanelId != 0U)
			{
				this.PanelId = other.PanelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00027D88 File Offset: 0x00025F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00027D94 File Offset: 0x00025F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 40U)
					{
						this.EICILFAIAEE = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.PBHFELEJFHJ = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.OHKNLLIHDGJ = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.PanelId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040005BB RID: 1467
		private static readonly MessageParser<BJKLPGEPCPO> _parser = new MessageParser<BJKLPGEPCPO>(() => new BJKLPGEPCPO());

		// Token: 0x040005BC RID: 1468
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005BD RID: 1469
		public const int EICILFAIAEEFieldNumber = 5;

		// Token: 0x040005BE RID: 1470
		private uint eICILFAIAEE_;

		// Token: 0x040005BF RID: 1471
		public const int OHKNLLIHDGJFieldNumber = 11;

		// Token: 0x040005C0 RID: 1472
		private uint oHKNLLIHDGJ_;

		// Token: 0x040005C1 RID: 1473
		public const int PBHFELEJFHJFieldNumber = 9;

		// Token: 0x040005C2 RID: 1474
		private uint pBHFELEJFHJ_;

		// Token: 0x040005C3 RID: 1475
		public const int PanelIdFieldNumber = 13;

		// Token: 0x040005C4 RID: 1476
		private uint panelId_;
	}
}
