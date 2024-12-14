using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F17 RID: 3863
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicSetAutoDressInMagicUnitScRsp : IMessage<RogueMagicSetAutoDressInMagicUnitScRsp>, IMessage, IEquatable<RogueMagicSetAutoDressInMagicUnitScRsp>, IDeepCloneable<RogueMagicSetAutoDressInMagicUnitScRsp>, IBufferMessage
	{
		// Token: 0x170030AB RID: 12459
		// (get) Token: 0x0600AC6E RID: 44142 RVA: 0x001CFFD1 File Offset: 0x001CE1D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicSetAutoDressInMagicUnitScRsp> Parser
		{
			get
			{
				return RogueMagicSetAutoDressInMagicUnitScRsp._parser;
			}
		}

		// Token: 0x170030AC RID: 12460
		// (get) Token: 0x0600AC6F RID: 44143 RVA: 0x001CFFD8 File Offset: 0x001CE1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicSetAutoDressInMagicUnitScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x0600AC70 RID: 44144 RVA: 0x001CFFEA File Offset: 0x001CE1EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicSetAutoDressInMagicUnitScRsp.Descriptor;
			}
		}

		// Token: 0x0600AC71 RID: 44145 RVA: 0x001CFFF1 File Offset: 0x001CE1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicSetAutoDressInMagicUnitScRsp()
		{
		}

		// Token: 0x0600AC72 RID: 44146 RVA: 0x001CFFF9 File Offset: 0x001CE1F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicSetAutoDressInMagicUnitScRsp(RogueMagicSetAutoDressInMagicUnitScRsp other) : this()
		{
			this.enableAutoDress_ = other.enableAutoDress_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC73 RID: 44147 RVA: 0x001D002A File Offset: 0x001CE22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicSetAutoDressInMagicUnitScRsp Clone()
		{
			return new RogueMagicSetAutoDressInMagicUnitScRsp(this);
		}

		// Token: 0x170030AE RID: 12462
		// (get) Token: 0x0600AC74 RID: 44148 RVA: 0x001D0032 File Offset: 0x001CE232
		// (set) Token: 0x0600AC75 RID: 44149 RVA: 0x001D003A File Offset: 0x001CE23A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnableAutoDress
		{
			get
			{
				return this.enableAutoDress_;
			}
			set
			{
				this.enableAutoDress_ = value;
			}
		}

		// Token: 0x170030AF RID: 12463
		// (get) Token: 0x0600AC76 RID: 44150 RVA: 0x001D0043 File Offset: 0x001CE243
		// (set) Token: 0x0600AC77 RID: 44151 RVA: 0x001D004B File Offset: 0x001CE24B
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

		// Token: 0x0600AC78 RID: 44152 RVA: 0x001D0054 File Offset: 0x001CE254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicSetAutoDressInMagicUnitScRsp);
		}

		// Token: 0x0600AC79 RID: 44153 RVA: 0x001D0062 File Offset: 0x001CE262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicSetAutoDressInMagicUnitScRsp other)
		{
			return other != null && (other == this || (this.EnableAutoDress == other.EnableAutoDress && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC7A RID: 44154 RVA: 0x001D00A0 File Offset: 0x001CE2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EnableAutoDress)
			{
				num ^= this.EnableAutoDress.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC7B RID: 44155 RVA: 0x001D00F8 File Offset: 0x001CE2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AC7C RID: 44156 RVA: 0x001D0100 File Offset: 0x001CE300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC7D RID: 44157 RVA: 0x001D010C File Offset: 0x001CE30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EnableAutoDress)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.EnableAutoDress);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC7E RID: 44158 RVA: 0x001D0168 File Offset: 0x001CE368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EnableAutoDress)
			{
				num += 2;
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC7F RID: 44159 RVA: 0x001D01B4 File Offset: 0x001CE3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicSetAutoDressInMagicUnitScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EnableAutoDress)
			{
				this.EnableAutoDress = other.EnableAutoDress;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC80 RID: 44160 RVA: 0x001D0204 File Offset: 0x001CE404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC81 RID: 44161 RVA: 0x001D0210 File Offset: 0x001CE410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.EnableAutoDress = input.ReadBool();
				}
			}
		}

		// Token: 0x04004644 RID: 17988
		private static readonly MessageParser<RogueMagicSetAutoDressInMagicUnitScRsp> _parser = new MessageParser<RogueMagicSetAutoDressInMagicUnitScRsp>(() => new RogueMagicSetAutoDressInMagicUnitScRsp());

		// Token: 0x04004645 RID: 17989
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004646 RID: 17990
		public const int EnableAutoDressFieldNumber = 4;

		// Token: 0x04004647 RID: 17991
		private bool enableAutoDress_;

		// Token: 0x04004648 RID: 17992
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04004649 RID: 17993
		private uint retcode_;
	}
}
