using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200118F RID: 4495
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartAetherDivideChallengeBattleScRsp : IMessage<StartAetherDivideChallengeBattleScRsp>, IMessage, IEquatable<StartAetherDivideChallengeBattleScRsp>, IDeepCloneable<StartAetherDivideChallengeBattleScRsp>, IBufferMessage
	{
		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x0600C8A3 RID: 51363 RVA: 0x0021A447 File Offset: 0x00218647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartAetherDivideChallengeBattleScRsp> Parser
		{
			get
			{
				return StartAetherDivideChallengeBattleScRsp._parser;
			}
		}

		// Token: 0x17003897 RID: 14487
		// (get) Token: 0x0600C8A4 RID: 51364 RVA: 0x0021A44E File Offset: 0x0021864E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartAetherDivideChallengeBattleScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003898 RID: 14488
		// (get) Token: 0x0600C8A5 RID: 51365 RVA: 0x0021A460 File Offset: 0x00218660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartAetherDivideChallengeBattleScRsp.Descriptor;
			}
		}

		// Token: 0x0600C8A6 RID: 51366 RVA: 0x0021A467 File Offset: 0x00218667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideChallengeBattleScRsp()
		{
		}

		// Token: 0x0600C8A7 RID: 51367 RVA: 0x0021A470 File Offset: 0x00218670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideChallengeBattleScRsp(StartAetherDivideChallengeBattleScRsp other) : this()
		{
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C8A8 RID: 51368 RVA: 0x0021A4BC File Offset: 0x002186BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideChallengeBattleScRsp Clone()
		{
			return new StartAetherDivideChallengeBattleScRsp(this);
		}

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x0600C8A9 RID: 51369 RVA: 0x0021A4C4 File Offset: 0x002186C4
		// (set) Token: 0x0600C8AA RID: 51370 RVA: 0x0021A4CC File Offset: 0x002186CC
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

		// Token: 0x1700389A RID: 14490
		// (get) Token: 0x0600C8AB RID: 51371 RVA: 0x0021A4D5 File Offset: 0x002186D5
		// (set) Token: 0x0600C8AC RID: 51372 RVA: 0x0021A4DD File Offset: 0x002186DD
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

		// Token: 0x0600C8AD RID: 51373 RVA: 0x0021A4E6 File Offset: 0x002186E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartAetherDivideChallengeBattleScRsp);
		}

		// Token: 0x0600C8AE RID: 51374 RVA: 0x0021A4F4 File Offset: 0x002186F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartAetherDivideChallengeBattleScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.BattleInfo, other.BattleInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C8AF RID: 51375 RVA: 0x0021A544 File Offset: 0x00218744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
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

		// Token: 0x0600C8B0 RID: 51376 RVA: 0x0021A599 File Offset: 0x00218799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C8B1 RID: 51377 RVA: 0x0021A5A1 File Offset: 0x002187A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C8B2 RID: 51378 RVA: 0x0021A5AC File Offset: 0x002187AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.BattleInfo);
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

		// Token: 0x0600C8B3 RID: 51379 RVA: 0x0021A608 File Offset: 0x00218808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
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

		// Token: 0x0600C8B4 RID: 51380 RVA: 0x0021A660 File Offset: 0x00218860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartAetherDivideChallengeBattleScRsp other)
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
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C8B5 RID: 51381 RVA: 0x0021A6C8 File Offset: 0x002188C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C8B6 RID: 51382 RVA: 0x0021A6D4 File Offset: 0x002188D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					if (num != 96U)
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
						this.BattleInfo = new AetherDivideBattleInfo();
					}
					input.ReadMessage(this.BattleInfo);
				}
			}
		}

		// Token: 0x040050FB RID: 20731
		private static readonly MessageParser<StartAetherDivideChallengeBattleScRsp> _parser = new MessageParser<StartAetherDivideChallengeBattleScRsp>(() => new StartAetherDivideChallengeBattleScRsp());

		// Token: 0x040050FC RID: 20732
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050FD RID: 20733
		public const int BattleInfoFieldNumber = 11;

		// Token: 0x040050FE RID: 20734
		private AetherDivideBattleInfo battleInfo_;

		// Token: 0x040050FF RID: 20735
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04005100 RID: 20736
		private uint retcode_;
	}
}
