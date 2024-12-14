using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000445 RID: 1093
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterFantasticStoryActivityStageScRsp : IMessage<EnterFantasticStoryActivityStageScRsp>, IMessage, IEquatable<EnterFantasticStoryActivityStageScRsp>, IDeepCloneable<EnterFantasticStoryActivityStageScRsp>, IBufferMessage
	{
		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06003088 RID: 12424 RVA: 0x00085417 File Offset: 0x00083617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterFantasticStoryActivityStageScRsp> Parser
		{
			get
			{
				return EnterFantasticStoryActivityStageScRsp._parser;
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06003089 RID: 12425 RVA: 0x0008541E File Offset: 0x0008361E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterFantasticStoryActivityStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x0600308A RID: 12426 RVA: 0x00085430 File Offset: 0x00083630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterFantasticStoryActivityStageScRsp.Descriptor;
			}
		}

		// Token: 0x0600308B RID: 12427 RVA: 0x00085437 File Offset: 0x00083637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFantasticStoryActivityStageScRsp()
		{
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x00085440 File Offset: 0x00083640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFantasticStoryActivityStageScRsp(EnterFantasticStoryActivityStageScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.kLANEABKELD_ = other.kLANEABKELD_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.battleId_ = other.battleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x000854A4 File Offset: 0x000836A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFantasticStoryActivityStageScRsp Clone()
		{
			return new EnterFantasticStoryActivityStageScRsp(this);
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x0600308E RID: 12430 RVA: 0x000854AC File Offset: 0x000836AC
		// (set) Token: 0x0600308F RID: 12431 RVA: 0x000854B4 File Offset: 0x000836B4
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

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06003090 RID: 12432 RVA: 0x000854BD File Offset: 0x000836BD
		// (set) Token: 0x06003091 RID: 12433 RVA: 0x000854C5 File Offset: 0x000836C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KLANEABKELD
		{
			get
			{
				return this.kLANEABKELD_;
			}
			set
			{
				this.kLANEABKELD_ = value;
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06003092 RID: 12434 RVA: 0x000854CE File Offset: 0x000836CE
		// (set) Token: 0x06003093 RID: 12435 RVA: 0x000854D6 File Offset: 0x000836D6
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

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06003094 RID: 12436 RVA: 0x000854DF File Offset: 0x000836DF
		// (set) Token: 0x06003095 RID: 12437 RVA: 0x000854E7 File Offset: 0x000836E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BattleId
		{
			get
			{
				return this.battleId_;
			}
			set
			{
				this.battleId_ = value;
			}
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x000854F0 File Offset: 0x000836F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterFantasticStoryActivityStageScRsp);
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x00085500 File Offset: 0x00083700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterFantasticStoryActivityStageScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.KLANEABKELD == other.KLANEABKELD && object.Equals(this.BattleInfo, other.BattleInfo) && this.BattleId == other.BattleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x00085570 File Offset: 0x00083770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.KLANEABKELD != 0U)
			{
				num ^= this.KLANEABKELD.GetHashCode();
			}
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this.BattleId != 0U)
			{
				num ^= this.BattleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x000855F7 File Offset: 0x000837F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x000855FF File Offset: 0x000837FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600309B RID: 12443 RVA: 0x00085608 File Offset: 0x00083808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.BattleId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.BattleId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this.KLANEABKELD != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.KLANEABKELD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600309C RID: 12444 RVA: 0x0008569C File Offset: 0x0008389C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.KLANEABKELD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KLANEABKELD);
			}
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this.BattleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x00085724 File Offset: 0x00083924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterFantasticStoryActivityStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.KLANEABKELD != 0U)
			{
				this.KLANEABKELD = other.KLANEABKELD;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			if (other.BattleId != 0U)
			{
				this.BattleId = other.BattleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x000857B4 File Offset: 0x000839B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600309F RID: 12447 RVA: 0x000857C0 File Offset: 0x000839C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 34U)
					{
						if (this.battleInfo_ == null)
						{
							this.BattleInfo = new SceneBattleInfo();
						}
						input.ReadMessage(this.BattleInfo);
						continue;
					}
					if (num == 72U)
					{
						this.BattleId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.KLANEABKELD = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400134D RID: 4941
		private static readonly MessageParser<EnterFantasticStoryActivityStageScRsp> _parser = new MessageParser<EnterFantasticStoryActivityStageScRsp>(() => new EnterFantasticStoryActivityStageScRsp());

		// Token: 0x0400134E RID: 4942
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400134F RID: 4943
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04001350 RID: 4944
		private uint retcode_;

		// Token: 0x04001351 RID: 4945
		public const int KLANEABKELDFieldNumber = 15;

		// Token: 0x04001352 RID: 4946
		private uint kLANEABKELD_;

		// Token: 0x04001353 RID: 4947
		public const int BattleInfoFieldNumber = 4;

		// Token: 0x04001354 RID: 4948
		private SceneBattleInfo battleInfo_;

		// Token: 0x04001355 RID: 4949
		public const int BattleIdFieldNumber = 9;

		// Token: 0x04001356 RID: 4950
		private uint battleId_;
	}
}
