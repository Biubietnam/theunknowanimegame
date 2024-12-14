using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000063 RID: 99
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherDivideSpiritExpUpScRsp : IMessage<AetherDivideSpiritExpUpScRsp>, IMessage, IEquatable<AetherDivideSpiritExpUpScRsp>, IDeepCloneable<AetherDivideSpiritExpUpScRsp>, IBufferMessage
	{
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0000C547 File Offset: 0x0000A747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherDivideSpiritExpUpScRsp> Parser
		{
			get
			{
				return AetherDivideSpiritExpUpScRsp._parser;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0000C54E File Offset: 0x0000A74E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherDivideSpiritExpUpScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0000C560 File Offset: 0x0000A760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherDivideSpiritExpUpScRsp.Descriptor;
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000C567 File Offset: 0x0000A767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSpiritExpUpScRsp()
		{
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000C570 File Offset: 0x0000A770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSpiritExpUpScRsp(AetherDivideSpiritExpUpScRsp other) : this()
		{
			this.aetherInfo_ = ((other.aetherInfo_ != null) ? other.aetherInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.nPGOMLFGBJM_ = other.nPGOMLFGBJM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000C5C8 File Offset: 0x0000A7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSpiritExpUpScRsp Clone()
		{
			return new AetherDivideSpiritExpUpScRsp(this);
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x0000C5D8 File Offset: 0x0000A7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSpiritInfo AetherInfo
		{
			get
			{
				return this.aetherInfo_;
			}
			set
			{
				this.aetherInfo_ = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0000C5E1 File Offset: 0x0000A7E1
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x0000C5E9 File Offset: 0x0000A7E9
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

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0000C5F2 File Offset: 0x0000A7F2
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x0000C5FA File Offset: 0x0000A7FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NPGOMLFGBJM
		{
			get
			{
				return this.nPGOMLFGBJM_;
			}
			set
			{
				this.nPGOMLFGBJM_ = value;
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000C603 File Offset: 0x0000A803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherDivideSpiritExpUpScRsp);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000C614 File Offset: 0x0000A814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherDivideSpiritExpUpScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.AetherInfo, other.AetherInfo) && this.Retcode == other.Retcode && this.NPGOMLFGBJM == other.NPGOMLFGBJM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000C674 File Offset: 0x0000A874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.aetherInfo_ != null)
			{
				num ^= this.AetherInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.NPGOMLFGBJM != 0U)
			{
				num ^= this.NPGOMLFGBJM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000C6E2 File Offset: 0x0000A8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000C6EA File Offset: 0x0000A8EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000C6F4 File Offset: 0x0000A8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.aetherInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.AetherInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.NPGOMLFGBJM != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.NPGOMLFGBJM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0000C76C File Offset: 0x0000A96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.aetherInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AetherInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.NPGOMLFGBJM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NPGOMLFGBJM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0000C7DC File Offset: 0x0000A9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherDivideSpiritExpUpScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.aetherInfo_ != null)
			{
				if (this.aetherInfo_ == null)
				{
					this.AetherInfo = new AetherDivideSpiritInfo();
				}
				this.AetherInfo.MergeFrom(other.AetherInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.NPGOMLFGBJM != 0U)
			{
				this.NPGOMLFGBJM = other.NPGOMLFGBJM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000C858 File Offset: 0x0000AA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0000C864 File Offset: 0x0000AA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 48U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NPGOMLFGBJM = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.aetherInfo_ == null)
					{
						this.AetherInfo = new AetherDivideSpiritInfo();
					}
					input.ReadMessage(this.AetherInfo);
				}
			}
		}

		// Token: 0x04000183 RID: 387
		private static readonly MessageParser<AetherDivideSpiritExpUpScRsp> _parser = new MessageParser<AetherDivideSpiritExpUpScRsp>(() => new AetherDivideSpiritExpUpScRsp());

		// Token: 0x04000184 RID: 388
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000185 RID: 389
		public const int AetherInfoFieldNumber = 3;

		// Token: 0x04000186 RID: 390
		private AetherDivideSpiritInfo aetherInfo_;

		// Token: 0x04000187 RID: 391
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04000188 RID: 392
		private uint retcode_;

		// Token: 0x04000189 RID: 393
		public const int NPGOMLFGBJMFieldNumber = 8;

		// Token: 0x0400018A RID: 394
		private uint nPGOMLFGBJM_;
	}
}
