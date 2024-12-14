using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001193 RID: 4499
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartAetherDivideSceneBattleScRsp : IMessage<StartAetherDivideSceneBattleScRsp>, IMessage, IEquatable<StartAetherDivideSceneBattleScRsp>, IDeepCloneable<StartAetherDivideSceneBattleScRsp>, IBufferMessage
	{
		// Token: 0x170038A5 RID: 14501
		// (get) Token: 0x0600C8D5 RID: 51413 RVA: 0x0021AD9F File Offset: 0x00218F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartAetherDivideSceneBattleScRsp> Parser
		{
			get
			{
				return StartAetherDivideSceneBattleScRsp._parser;
			}
		}

		// Token: 0x170038A6 RID: 14502
		// (get) Token: 0x0600C8D6 RID: 51414 RVA: 0x0021ADA6 File Offset: 0x00218FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartAetherDivideSceneBattleScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170038A7 RID: 14503
		// (get) Token: 0x0600C8D7 RID: 51415 RVA: 0x0021ADB8 File Offset: 0x00218FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartAetherDivideSceneBattleScRsp.Descriptor;
			}
		}

		// Token: 0x0600C8D8 RID: 51416 RVA: 0x0021ADBF File Offset: 0x00218FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideSceneBattleScRsp()
		{
		}

		// Token: 0x0600C8D9 RID: 51417 RVA: 0x0021ADC8 File Offset: 0x00218FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideSceneBattleScRsp(StartAetherDivideSceneBattleScRsp other) : this()
		{
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.castEntityId_ = other.castEntityId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C8DA RID: 51418 RVA: 0x0021AE20 File Offset: 0x00219020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideSceneBattleScRsp Clone()
		{
			return new StartAetherDivideSceneBattleScRsp(this);
		}

		// Token: 0x170038A8 RID: 14504
		// (get) Token: 0x0600C8DB RID: 51419 RVA: 0x0021AE28 File Offset: 0x00219028
		// (set) Token: 0x0600C8DC RID: 51420 RVA: 0x0021AE30 File Offset: 0x00219030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideBattleInfo BattleInfo
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

		// Token: 0x170038A9 RID: 14505
		// (get) Token: 0x0600C8DD RID: 51421 RVA: 0x0021AE39 File Offset: 0x00219039
		// (set) Token: 0x0600C8DE RID: 51422 RVA: 0x0021AE41 File Offset: 0x00219041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CastEntityId
		{
			get
			{
				return this.castEntityId_;
			}
			set
			{
				this.castEntityId_ = value;
			}
		}

		// Token: 0x170038AA RID: 14506
		// (get) Token: 0x0600C8DF RID: 51423 RVA: 0x0021AE4A File Offset: 0x0021904A
		// (set) Token: 0x0600C8E0 RID: 51424 RVA: 0x0021AE52 File Offset: 0x00219052
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

		// Token: 0x0600C8E1 RID: 51425 RVA: 0x0021AE5B File Offset: 0x0021905B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartAetherDivideSceneBattleScRsp);
		}

		// Token: 0x0600C8E2 RID: 51426 RVA: 0x0021AE6C File Offset: 0x0021906C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartAetherDivideSceneBattleScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.BattleInfo, other.BattleInfo) && this.CastEntityId == other.CastEntityId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C8E3 RID: 51427 RVA: 0x0021AECC File Offset: 0x002190CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this.CastEntityId != 0U)
			{
				num ^= this.CastEntityId.GetHashCode();
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

		// Token: 0x0600C8E4 RID: 51428 RVA: 0x0021AF3A File Offset: 0x0021913A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C8E5 RID: 51429 RVA: 0x0021AF42 File Offset: 0x00219142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C8E6 RID: 51430 RVA: 0x0021AF4C File Offset: 0x0021914C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.CastEntityId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.CastEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C8E7 RID: 51431 RVA: 0x0021AFC4 File Offset: 0x002191C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this.CastEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CastEntityId);
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

		// Token: 0x0600C8E8 RID: 51432 RVA: 0x0021B034 File Offset: 0x00219234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartAetherDivideSceneBattleScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new AetherDivideBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			if (other.CastEntityId != 0U)
			{
				this.CastEntityId = other.CastEntityId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C8E9 RID: 51433 RVA: 0x0021B0B0 File Offset: 0x002192B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C8EA RID: 51434 RVA: 0x0021B0BC File Offset: 0x002192BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CastEntityId = input.ReadUInt32();
						}
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
						this.BattleInfo = new AetherDivideBattleInfo();
					}
					input.ReadMessage(this.BattleInfo);
				}
			}
		}

		// Token: 0x04005111 RID: 20753
		private static readonly MessageParser<StartAetherDivideSceneBattleScRsp> _parser = new MessageParser<StartAetherDivideSceneBattleScRsp>(() => new StartAetherDivideSceneBattleScRsp());

		// Token: 0x04005112 RID: 20754
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005113 RID: 20755
		public const int BattleInfoFieldNumber = 1;

		// Token: 0x04005114 RID: 20756
		private AetherDivideBattleInfo battleInfo_;

		// Token: 0x04005115 RID: 20757
		public const int CastEntityIdFieldNumber = 13;

		// Token: 0x04005116 RID: 20758
		private uint castEntityId_;

		// Token: 0x04005117 RID: 20759
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04005118 RID: 20760
		private uint retcode_;
	}
}
