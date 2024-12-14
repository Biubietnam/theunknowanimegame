using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D45 RID: 3397
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuitBattleCsReq : IMessage<QuitBattleCsReq>, IMessage, IEquatable<QuitBattleCsReq>, IDeepCloneable<QuitBattleCsReq>, IBufferMessage
	{
		// Token: 0x17002ADA RID: 10970
		// (get) Token: 0x060097C5 RID: 38853 RVA: 0x00194847 File Offset: 0x00192A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuitBattleCsReq> Parser
		{
			get
			{
				return QuitBattleCsReq._parser;
			}
		}

		// Token: 0x17002ADB RID: 10971
		// (get) Token: 0x060097C6 RID: 38854 RVA: 0x0019484E File Offset: 0x00192A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuitBattleCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002ADC RID: 10972
		// (get) Token: 0x060097C7 RID: 38855 RVA: 0x00194860 File Offset: 0x00192A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuitBattleCsReq.Descriptor;
			}
		}

		// Token: 0x060097C8 RID: 38856 RVA: 0x00194867 File Offset: 0x00192A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitBattleCsReq()
		{
		}

		// Token: 0x060097C9 RID: 38857 RVA: 0x00194870 File Offset: 0x00192A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitBattleCsReq(QuitBattleCsReq other) : this()
		{
			this.stt_ = ((other.stt_ != null) ? other.stt_.Clone() : null);
			this.rebattleType_ = other.rebattleType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097CA RID: 38858 RVA: 0x001948BC File Offset: 0x00192ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitBattleCsReq Clone()
		{
			return new QuitBattleCsReq(this);
		}

		// Token: 0x17002ADD RID: 10973
		// (get) Token: 0x060097CB RID: 38859 RVA: 0x001948C4 File Offset: 0x00192AC4
		// (set) Token: 0x060097CC RID: 38860 RVA: 0x001948CC File Offset: 0x00192ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStatistics Stt
		{
			get
			{
				return this.stt_;
			}
			set
			{
				this.stt_ = value;
			}
		}

		// Token: 0x17002ADE RID: 10974
		// (get) Token: 0x060097CD RID: 38861 RVA: 0x001948D5 File Offset: 0x00192AD5
		// (set) Token: 0x060097CE RID: 38862 RVA: 0x001948DD File Offset: 0x00192ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RebattleType RebattleType
		{
			get
			{
				return this.rebattleType_;
			}
			set
			{
				this.rebattleType_ = value;
			}
		}

		// Token: 0x060097CF RID: 38863 RVA: 0x001948E6 File Offset: 0x00192AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuitBattleCsReq);
		}

		// Token: 0x060097D0 RID: 38864 RVA: 0x001948F4 File Offset: 0x00192AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuitBattleCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.Stt, other.Stt) && this.RebattleType == other.RebattleType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060097D1 RID: 38865 RVA: 0x00194944 File Offset: 0x00192B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.stt_ != null)
			{
				num ^= this.Stt.GetHashCode();
			}
			if (this.RebattleType != RebattleType.None)
			{
				num ^= this.RebattleType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060097D2 RID: 38866 RVA: 0x0019499F File Offset: 0x00192B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060097D3 RID: 38867 RVA: 0x001949A7 File Offset: 0x00192BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097D4 RID: 38868 RVA: 0x001949B0 File Offset: 0x00192BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RebattleType != RebattleType.None)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.RebattleType);
			}
			if (this.stt_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Stt);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060097D5 RID: 38869 RVA: 0x00194A0C File Offset: 0x00192C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.stt_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Stt);
			}
			if (this.RebattleType != RebattleType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RebattleType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060097D6 RID: 38870 RVA: 0x00194A64 File Offset: 0x00192C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuitBattleCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.stt_ != null)
			{
				if (this.stt_ == null)
				{
					this.Stt = new BattleStatistics();
				}
				this.Stt.MergeFrom(other.Stt);
			}
			if (other.RebattleType != RebattleType.None)
			{
				this.RebattleType = other.RebattleType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060097D7 RID: 38871 RVA: 0x00194ACC File Offset: 0x00192CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097D8 RID: 38872 RVA: 0x00194AD8 File Offset: 0x00192CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.stt_ == null)
						{
							this.Stt = new BattleStatistics();
						}
						input.ReadMessage(this.Stt);
					}
				}
				else
				{
					this.RebattleType = (RebattleType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003B0A RID: 15114
		private static readonly MessageParser<QuitBattleCsReq> _parser = new MessageParser<QuitBattleCsReq>(() => new QuitBattleCsReq());

		// Token: 0x04003B0B RID: 15115
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B0C RID: 15116
		public const int SttFieldNumber = 5;

		// Token: 0x04003B0D RID: 15117
		private BattleStatistics stt_;

		// Token: 0x04003B0E RID: 15118
		public const int RebattleTypeFieldNumber = 4;

		// Token: 0x04003B0F RID: 15119
		private RebattleType rebattleType_;
	}
}
