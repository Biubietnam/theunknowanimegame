using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B25 RID: 2853
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyDailySettleScNotify : IMessage<MonopolyDailySettleScNotify>, IMessage, IEquatable<MonopolyDailySettleScNotify>, IDeepCloneable<MonopolyDailySettleScNotify>, IBufferMessage
	{
		// Token: 0x1700236D RID: 9069
		// (get) Token: 0x06007E45 RID: 32325 RVA: 0x0014DDAB File Offset: 0x0014BFAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyDailySettleScNotify> Parser
		{
			get
			{
				return MonopolyDailySettleScNotify._parser;
			}
		}

		// Token: 0x1700236E RID: 9070
		// (get) Token: 0x06007E46 RID: 32326 RVA: 0x0014DDB2 File Offset: 0x0014BFB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyDailySettleScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700236F RID: 9071
		// (get) Token: 0x06007E47 RID: 32327 RVA: 0x0014DDC4 File Offset: 0x0014BFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyDailySettleScNotify.Descriptor;
			}
		}

		// Token: 0x06007E48 RID: 32328 RVA: 0x0014DDCB File Offset: 0x0014BFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyDailySettleScNotify()
		{
		}

		// Token: 0x06007E49 RID: 32329 RVA: 0x0014DDD4 File Offset: 0x0014BFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyDailySettleScNotify(MonopolyDailySettleScNotify other) : this()
		{
			this.pCOEFKDDBOE_ = ((other.pCOEFKDDBOE_ != null) ? other.pCOEFKDDBOE_.Clone() : null);
			this.hOOEOJELHID_ = other.hOOEOJELHID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E4A RID: 32330 RVA: 0x0014DE20 File Offset: 0x0014C020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyDailySettleScNotify Clone()
		{
			return new MonopolyDailySettleScNotify(this);
		}

		// Token: 0x17002370 RID: 9072
		// (get) Token: 0x06007E4B RID: 32331 RVA: 0x0014DE28 File Offset: 0x0014C028
		// (set) Token: 0x06007E4C RID: 32332 RVA: 0x0014DE30 File Offset: 0x0014C030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEEFPPBEAOF PCOEFKDDBOE
		{
			get
			{
				return this.pCOEFKDDBOE_;
			}
			set
			{
				this.pCOEFKDDBOE_ = value;
			}
		}

		// Token: 0x17002371 RID: 9073
		// (get) Token: 0x06007E4D RID: 32333 RVA: 0x0014DE39 File Offset: 0x0014C039
		// (set) Token: 0x06007E4E RID: 32334 RVA: 0x0014DE41 File Offset: 0x0014C041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HOOEOJELHID
		{
			get
			{
				return this.hOOEOJELHID_;
			}
			set
			{
				this.hOOEOJELHID_ = value;
			}
		}

		// Token: 0x06007E4F RID: 32335 RVA: 0x0014DE4A File Offset: 0x0014C04A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyDailySettleScNotify);
		}

		// Token: 0x06007E50 RID: 32336 RVA: 0x0014DE58 File Offset: 0x0014C058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyDailySettleScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PCOEFKDDBOE, other.PCOEFKDDBOE) && this.HOOEOJELHID == other.HOOEOJELHID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E51 RID: 32337 RVA: 0x0014DEA8 File Offset: 0x0014C0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pCOEFKDDBOE_ != null)
			{
				num ^= this.PCOEFKDDBOE.GetHashCode();
			}
			if (this.HOOEOJELHID != 0U)
			{
				num ^= this.HOOEOJELHID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E52 RID: 32338 RVA: 0x0014DEFD File Offset: 0x0014C0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007E53 RID: 32339 RVA: 0x0014DF05 File Offset: 0x0014C105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E54 RID: 32340 RVA: 0x0014DF10 File Offset: 0x0014C110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HOOEOJELHID != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.HOOEOJELHID);
			}
			if (this.pCOEFKDDBOE_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.PCOEFKDDBOE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E55 RID: 32341 RVA: 0x0014DF6C File Offset: 0x0014C16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pCOEFKDDBOE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PCOEFKDDBOE);
			}
			if (this.HOOEOJELHID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HOOEOJELHID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E56 RID: 32342 RVA: 0x0014DFC4 File Offset: 0x0014C1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyDailySettleScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pCOEFKDDBOE_ != null)
			{
				if (this.pCOEFKDDBOE_ == null)
				{
					this.PCOEFKDDBOE = new OEEFPPBEAOF();
				}
				this.PCOEFKDDBOE.MergeFrom(other.PCOEFKDDBOE);
			}
			if (other.HOOEOJELHID != 0U)
			{
				this.HOOEOJELHID = other.HOOEOJELHID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E57 RID: 32343 RVA: 0x0014E02C File Offset: 0x0014C22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E58 RID: 32344 RVA: 0x0014E038 File Offset: 0x0014C238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.pCOEFKDDBOE_ == null)
						{
							this.PCOEFKDDBOE = new OEEFPPBEAOF();
						}
						input.ReadMessage(this.PCOEFKDDBOE);
					}
				}
				else
				{
					this.HOOEOJELHID = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400306C RID: 12396
		private static readonly MessageParser<MonopolyDailySettleScNotify> _parser = new MessageParser<MonopolyDailySettleScNotify>(() => new MonopolyDailySettleScNotify());

		// Token: 0x0400306D RID: 12397
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400306E RID: 12398
		public const int PCOEFKDDBOEFieldNumber = 6;

		// Token: 0x0400306F RID: 12399
		private OEEFPPBEAOF pCOEFKDDBOE_;

		// Token: 0x04003070 RID: 12400
		public const int HOOEOJELHIDFieldNumber = 4;

		// Token: 0x04003071 RID: 12401
		private uint hOOEOJELHID_;
	}
}
