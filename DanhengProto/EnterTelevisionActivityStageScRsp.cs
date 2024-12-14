using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000479 RID: 1145
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterTelevisionActivityStageScRsp : IMessage<EnterTelevisionActivityStageScRsp>, IMessage, IEquatable<EnterTelevisionActivityStageScRsp>, IDeepCloneable<EnterTelevisionActivityStageScRsp>, IBufferMessage
	{
		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x060032FF RID: 13055 RVA: 0x0008C493 File Offset: 0x0008A693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterTelevisionActivityStageScRsp> Parser
		{
			get
			{
				return EnterTelevisionActivityStageScRsp._parser;
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06003300 RID: 13056 RVA: 0x0008C49A File Offset: 0x0008A69A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterTelevisionActivityStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06003301 RID: 13057 RVA: 0x0008C4AC File Offset: 0x0008A6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterTelevisionActivityStageScRsp.Descriptor;
			}
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x0008C4B3 File Offset: 0x0008A6B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTelevisionActivityStageScRsp()
		{
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x0008C4BC File Offset: 0x0008A6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTelevisionActivityStageScRsp(EnterTelevisionActivityStageScRsp other) : this()
		{
			this.dNFJOOAJIKG_ = other.dNFJOOAJIKG_;
			this.retcode_ = other.retcode_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x0008C514 File Offset: 0x0008A714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTelevisionActivityStageScRsp Clone()
		{
			return new EnterTelevisionActivityStageScRsp(this);
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06003305 RID: 13061 RVA: 0x0008C51C File Offset: 0x0008A71C
		// (set) Token: 0x06003306 RID: 13062 RVA: 0x0008C524 File Offset: 0x0008A724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DNFJOOAJIKG
		{
			get
			{
				return this.dNFJOOAJIKG_;
			}
			set
			{
				this.dNFJOOAJIKG_ = value;
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06003307 RID: 13063 RVA: 0x0008C52D File Offset: 0x0008A72D
		// (set) Token: 0x06003308 RID: 13064 RVA: 0x0008C535 File Offset: 0x0008A735
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

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06003309 RID: 13065 RVA: 0x0008C53E File Offset: 0x0008A73E
		// (set) Token: 0x0600330A RID: 13066 RVA: 0x0008C546 File Offset: 0x0008A746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
			set
			{
				this.battleInfo_ = value;
			}
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x0008C54F File Offset: 0x0008A74F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterTelevisionActivityStageScRsp);
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x0008C560 File Offset: 0x0008A760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterTelevisionActivityStageScRsp other)
		{
			return other != null && (other == this || (this.DNFJOOAJIKG == other.DNFJOOAJIKG && this.Retcode == other.Retcode && object.Equals(this.BattleInfo, other.BattleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x0008C5C0 File Offset: 0x0008A7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DNFJOOAJIKG != 0U)
			{
				num ^= this.DNFJOOAJIKG.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x0008C62E File Offset: 0x0008A82E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x0008C636 File Offset: 0x0008A836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x0008C640 File Offset: 0x0008A840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DNFJOOAJIKG != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.DNFJOOAJIKG);
			}
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x0008C6B4 File Offset: 0x0008A8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DNFJOOAJIKG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DNFJOOAJIKG);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x0008C724 File Offset: 0x0008A924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterTelevisionActivityStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DNFJOOAJIKG != 0U)
			{
				this.DNFJOOAJIKG = other.DNFJOOAJIKG;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x0008C7A0 File Offset: 0x0008A9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x0008C7AC File Offset: 0x0008A9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 50U)
					{
						if (num != 64U)
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
						if (this.battleInfo_ == null)
						{
							this.BattleInfo = new SceneBattleInfo();
						}
						input.ReadMessage(this.BattleInfo);
					}
				}
				else
				{
					this.DNFJOOAJIKG = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400144D RID: 5197
		private static readonly MessageParser<EnterTelevisionActivityStageScRsp> _parser = new MessageParser<EnterTelevisionActivityStageScRsp>(() => new EnterTelevisionActivityStageScRsp());

		// Token: 0x0400144E RID: 5198
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400144F RID: 5199
		public const int DNFJOOAJIKGFieldNumber = 1;

		// Token: 0x04001450 RID: 5200
		private uint dNFJOOAJIKG_;

		// Token: 0x04001451 RID: 5201
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04001452 RID: 5202
		private uint retcode_;

		// Token: 0x04001453 RID: 5203
		public const int BattleInfoFieldNumber = 6;

		// Token: 0x04001454 RID: 5204
		private SceneBattleInfo battleInfo_;
	}
}
