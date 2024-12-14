using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001197 RID: 4503
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartAetherDivideStageBattleScRsp : IMessage<StartAetherDivideStageBattleScRsp>, IMessage, IEquatable<StartAetherDivideStageBattleScRsp>, IDeepCloneable<StartAetherDivideStageBattleScRsp>, IBufferMessage
	{
		// Token: 0x170038B1 RID: 14513
		// (get) Token: 0x0600C903 RID: 51459 RVA: 0x0021B467 File Offset: 0x00219667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartAetherDivideStageBattleScRsp> Parser
		{
			get
			{
				return StartAetherDivideStageBattleScRsp._parser;
			}
		}

		// Token: 0x170038B2 RID: 14514
		// (get) Token: 0x0600C904 RID: 51460 RVA: 0x0021B46E File Offset: 0x0021966E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartAetherDivideStageBattleScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170038B3 RID: 14515
		// (get) Token: 0x0600C905 RID: 51461 RVA: 0x0021B480 File Offset: 0x00219680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartAetherDivideStageBattleScRsp.Descriptor;
			}
		}

		// Token: 0x0600C906 RID: 51462 RVA: 0x0021B487 File Offset: 0x00219687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideStageBattleScRsp()
		{
		}

		// Token: 0x0600C907 RID: 51463 RVA: 0x0021B490 File Offset: 0x00219690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideStageBattleScRsp(StartAetherDivideStageBattleScRsp other) : this()
		{
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C908 RID: 51464 RVA: 0x0021B4DC File Offset: 0x002196DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideStageBattleScRsp Clone()
		{
			return new StartAetherDivideStageBattleScRsp(this);
		}

		// Token: 0x170038B4 RID: 14516
		// (get) Token: 0x0600C909 RID: 51465 RVA: 0x0021B4E4 File Offset: 0x002196E4
		// (set) Token: 0x0600C90A RID: 51466 RVA: 0x0021B4EC File Offset: 0x002196EC
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

		// Token: 0x170038B5 RID: 14517
		// (get) Token: 0x0600C90B RID: 51467 RVA: 0x0021B4F5 File Offset: 0x002196F5
		// (set) Token: 0x0600C90C RID: 51468 RVA: 0x0021B4FD File Offset: 0x002196FD
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

		// Token: 0x0600C90D RID: 51469 RVA: 0x0021B506 File Offset: 0x00219706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartAetherDivideStageBattleScRsp);
		}

		// Token: 0x0600C90E RID: 51470 RVA: 0x0021B514 File Offset: 0x00219714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartAetherDivideStageBattleScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.BattleInfo, other.BattleInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C90F RID: 51471 RVA: 0x0021B564 File Offset: 0x00219764
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

		// Token: 0x0600C910 RID: 51472 RVA: 0x0021B5B9 File Offset: 0x002197B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C911 RID: 51473 RVA: 0x0021B5C1 File Offset: 0x002197C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C912 RID: 51474 RVA: 0x0021B5CC File Offset: 0x002197CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C913 RID: 51475 RVA: 0x0021B628 File Offset: 0x00219828
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

		// Token: 0x0600C914 RID: 51476 RVA: 0x0021B680 File Offset: 0x00219880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartAetherDivideStageBattleScRsp other)
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

		// Token: 0x0600C915 RID: 51477 RVA: 0x0021B6E8 File Offset: 0x002198E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C916 RID: 51478 RVA: 0x0021B6F4 File Offset: 0x002198F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					if (num != 112U)
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

		// Token: 0x0400511F RID: 20767
		private static readonly MessageParser<StartAetherDivideStageBattleScRsp> _parser = new MessageParser<StartAetherDivideStageBattleScRsp>(() => new StartAetherDivideStageBattleScRsp());

		// Token: 0x04005120 RID: 20768
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005121 RID: 20769
		public const int BattleInfoFieldNumber = 12;

		// Token: 0x04005122 RID: 20770
		private AetherDivideBattleInfo battleInfo_;

		// Token: 0x04005123 RID: 20771
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04005124 RID: 20772
		private uint retcode_;
	}
}
