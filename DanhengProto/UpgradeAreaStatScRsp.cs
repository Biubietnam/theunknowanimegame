using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001407 RID: 5127
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpgradeAreaStatScRsp : IMessage<UpgradeAreaStatScRsp>, IMessage, IEquatable<UpgradeAreaStatScRsp>, IDeepCloneable<UpgradeAreaStatScRsp>, IBufferMessage
	{
		// Token: 0x1700402F RID: 16431
		// (get) Token: 0x0600E4A0 RID: 58528 RVA: 0x0025FD9F File Offset: 0x0025DF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpgradeAreaStatScRsp> Parser
		{
			get
			{
				return UpgradeAreaStatScRsp._parser;
			}
		}

		// Token: 0x17004030 RID: 16432
		// (get) Token: 0x0600E4A1 RID: 58529 RVA: 0x0025FDA6 File Offset: 0x0025DFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpgradeAreaStatScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004031 RID: 16433
		// (get) Token: 0x0600E4A2 RID: 58530 RVA: 0x0025FDB8 File Offset: 0x0025DFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpgradeAreaStatScRsp.Descriptor;
			}
		}

		// Token: 0x0600E4A3 RID: 58531 RVA: 0x0025FDBF File Offset: 0x0025DFBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpgradeAreaStatScRsp()
		{
		}

		// Token: 0x0600E4A4 RID: 58532 RVA: 0x0025FDC8 File Offset: 0x0025DFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpgradeAreaStatScRsp(UpgradeAreaStatScRsp other) : this()
		{
			this.iFJEBOIEGFG_ = other.iFJEBOIEGFG_;
			this.retcode_ = other.retcode_;
			this.areaId_ = other.areaId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E4A5 RID: 58533 RVA: 0x0025FE1C File Offset: 0x0025E01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpgradeAreaStatScRsp Clone()
		{
			return new UpgradeAreaStatScRsp(this);
		}

		// Token: 0x17004032 RID: 16434
		// (get) Token: 0x0600E4A6 RID: 58534 RVA: 0x0025FE24 File Offset: 0x0025E024
		// (set) Token: 0x0600E4A7 RID: 58535 RVA: 0x0025FE2C File Offset: 0x0025E02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StatType IFJEBOIEGFG
		{
			get
			{
				return this.iFJEBOIEGFG_;
			}
			set
			{
				this.iFJEBOIEGFG_ = value;
			}
		}

		// Token: 0x17004033 RID: 16435
		// (get) Token: 0x0600E4A8 RID: 58536 RVA: 0x0025FE35 File Offset: 0x0025E035
		// (set) Token: 0x0600E4A9 RID: 58537 RVA: 0x0025FE3D File Offset: 0x0025E03D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17004034 RID: 16436
		// (get) Token: 0x0600E4AA RID: 58538 RVA: 0x0025FE46 File Offset: 0x0025E046
		// (set) Token: 0x0600E4AB RID: 58539 RVA: 0x0025FE4E File Offset: 0x0025E04E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x17004035 RID: 16437
		// (get) Token: 0x0600E4AC RID: 58540 RVA: 0x0025FE57 File Offset: 0x0025E057
		// (set) Token: 0x0600E4AD RID: 58541 RVA: 0x0025FE5F File Offset: 0x0025E05F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x0600E4AE RID: 58542 RVA: 0x0025FE68 File Offset: 0x0025E068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpgradeAreaStatScRsp);
		}

		// Token: 0x0600E4AF RID: 58543 RVA: 0x0025FE78 File Offset: 0x0025E078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpgradeAreaStatScRsp other)
		{
			return other != null && (other == this || (this.IFJEBOIEGFG == other.IFJEBOIEGFG && this.Retcode == other.Retcode && this.AreaId == other.AreaId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E4B0 RID: 58544 RVA: 0x0025FEE4 File Offset: 0x0025E0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IFJEBOIEGFG != StatType.None)
			{
				num ^= this.IFJEBOIEGFG.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E4B1 RID: 58545 RVA: 0x0025FF74 File Offset: 0x0025E174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E4B2 RID: 58546 RVA: 0x0025FF7C File Offset: 0x0025E17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E4B3 RID: 58547 RVA: 0x0025FF88 File Offset: 0x0025E188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Level);
			}
			if (this.IFJEBOIEGFG != StatType.None)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.IFJEBOIEGFG);
			}
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.AreaId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E4B4 RID: 58548 RVA: 0x0026001C File Offset: 0x0025E21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IFJEBOIEGFG != StatType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.IFJEBOIEGFG);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E4B5 RID: 58549 RVA: 0x002600A4 File Offset: 0x0025E2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpgradeAreaStatScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IFJEBOIEGFG != StatType.None)
			{
				this.IFJEBOIEGFG = other.IFJEBOIEGFG;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E4B6 RID: 58550 RVA: 0x0026011C File Offset: 0x0025E31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E4B7 RID: 58551 RVA: 0x00260128 File Offset: 0x0025E328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.IFJEBOIEGFG = (StatType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.AreaId = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005ACE RID: 23246
		private static readonly MessageParser<UpgradeAreaStatScRsp> _parser = new MessageParser<UpgradeAreaStatScRsp>(() => new UpgradeAreaStatScRsp());

		// Token: 0x04005ACF RID: 23247
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AD0 RID: 23248
		public const int IFJEBOIEGFGFieldNumber = 8;

		// Token: 0x04005AD1 RID: 23249
		private StatType iFJEBOIEGFG_;

		// Token: 0x04005AD2 RID: 23250
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04005AD3 RID: 23251
		private uint retcode_;

		// Token: 0x04005AD4 RID: 23252
		public const int AreaIdFieldNumber = 9;

		// Token: 0x04005AD5 RID: 23253
		private uint areaId_;

		// Token: 0x04005AD6 RID: 23254
		public const int LevelFieldNumber = 2;

		// Token: 0x04005AD7 RID: 23255
		private uint level_;
	}
}
