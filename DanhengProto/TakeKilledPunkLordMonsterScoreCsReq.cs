using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012DB RID: 4827
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeKilledPunkLordMonsterScoreCsReq : IMessage<TakeKilledPunkLordMonsterScoreCsReq>, IMessage, IEquatable<TakeKilledPunkLordMonsterScoreCsReq>, IDeepCloneable<TakeKilledPunkLordMonsterScoreCsReq>, IBufferMessage
	{
		// Token: 0x17003C8A RID: 15498
		// (get) Token: 0x0600D75B RID: 55131 RVA: 0x0023E593 File Offset: 0x0023C793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeKilledPunkLordMonsterScoreCsReq> Parser
		{
			get
			{
				return TakeKilledPunkLordMonsterScoreCsReq._parser;
			}
		}

		// Token: 0x17003C8B RID: 15499
		// (get) Token: 0x0600D75C RID: 55132 RVA: 0x0023E59A File Offset: 0x0023C79A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeKilledPunkLordMonsterScoreCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C8C RID: 15500
		// (get) Token: 0x0600D75D RID: 55133 RVA: 0x0023E5AC File Offset: 0x0023C7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeKilledPunkLordMonsterScoreCsReq.Descriptor;
			}
		}

		// Token: 0x0600D75E RID: 55134 RVA: 0x0023E5B3 File Offset: 0x0023C7B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeKilledPunkLordMonsterScoreCsReq()
		{
		}

		// Token: 0x0600D75F RID: 55135 RVA: 0x0023E5BC File Offset: 0x0023C7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeKilledPunkLordMonsterScoreCsReq(TakeKilledPunkLordMonsterScoreCsReq other) : this()
		{
			this.mHEIIMDJKLC_ = other.mHEIIMDJKLC_;
			this.lEHPJLFNONE_ = ((other.lEHPJLFNONE_ != null) ? other.lEHPJLFNONE_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D760 RID: 55136 RVA: 0x0023E608 File Offset: 0x0023C808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeKilledPunkLordMonsterScoreCsReq Clone()
		{
			return new TakeKilledPunkLordMonsterScoreCsReq(this);
		}

		// Token: 0x17003C8D RID: 15501
		// (get) Token: 0x0600D761 RID: 55137 RVA: 0x0023E610 File Offset: 0x0023C810
		// (set) Token: 0x0600D762 RID: 55138 RVA: 0x0023E618 File Offset: 0x0023C818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MHEIIMDJKLC
		{
			get
			{
				return this.mHEIIMDJKLC_;
			}
			set
			{
				this.mHEIIMDJKLC_ = value;
			}
		}

		// Token: 0x17003C8E RID: 15502
		// (get) Token: 0x0600D763 RID: 55139 RVA: 0x0023E621 File Offset: 0x0023C821
		// (set) Token: 0x0600D764 RID: 55140 RVA: 0x0023E629 File Offset: 0x0023C829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterKey LEHPJLFNONE
		{
			get
			{
				return this.lEHPJLFNONE_;
			}
			set
			{
				this.lEHPJLFNONE_ = value;
			}
		}

		// Token: 0x0600D765 RID: 55141 RVA: 0x0023E632 File Offset: 0x0023C832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeKilledPunkLordMonsterScoreCsReq);
		}

		// Token: 0x0600D766 RID: 55142 RVA: 0x0023E640 File Offset: 0x0023C840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeKilledPunkLordMonsterScoreCsReq other)
		{
			return other != null && (other == this || (this.MHEIIMDJKLC == other.MHEIIMDJKLC && object.Equals(this.LEHPJLFNONE, other.LEHPJLFNONE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D767 RID: 55143 RVA: 0x0023E690 File Offset: 0x0023C890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MHEIIMDJKLC)
			{
				num ^= this.MHEIIMDJKLC.GetHashCode();
			}
			if (this.lEHPJLFNONE_ != null)
			{
				num ^= this.LEHPJLFNONE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D768 RID: 55144 RVA: 0x0023E6E5 File Offset: 0x0023C8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D769 RID: 55145 RVA: 0x0023E6ED File Offset: 0x0023C8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D76A RID: 55146 RVA: 0x0023E6F8 File Offset: 0x0023C8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MHEIIMDJKLC)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.MHEIIMDJKLC);
			}
			if (this.lEHPJLFNONE_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.LEHPJLFNONE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D76B RID: 55147 RVA: 0x0023E754 File Offset: 0x0023C954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MHEIIMDJKLC)
			{
				num += 2;
			}
			if (this.lEHPJLFNONE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LEHPJLFNONE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D76C RID: 55148 RVA: 0x0023E7A0 File Offset: 0x0023C9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeKilledPunkLordMonsterScoreCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MHEIIMDJKLC)
			{
				this.MHEIIMDJKLC = other.MHEIIMDJKLC;
			}
			if (other.lEHPJLFNONE_ != null)
			{
				if (this.lEHPJLFNONE_ == null)
				{
					this.LEHPJLFNONE = new PunkLordMonsterKey();
				}
				this.LEHPJLFNONE.MergeFrom(other.LEHPJLFNONE);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D76D RID: 55149 RVA: 0x0023E808 File Offset: 0x0023CA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D76E RID: 55150 RVA: 0x0023E814 File Offset: 0x0023CA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.lEHPJLFNONE_ == null)
						{
							this.LEHPJLFNONE = new PunkLordMonsterKey();
						}
						input.ReadMessage(this.LEHPJLFNONE);
					}
				}
				else
				{
					this.MHEIIMDJKLC = input.ReadBool();
				}
			}
		}

		// Token: 0x040055F3 RID: 22003
		private static readonly MessageParser<TakeKilledPunkLordMonsterScoreCsReq> _parser = new MessageParser<TakeKilledPunkLordMonsterScoreCsReq>(() => new TakeKilledPunkLordMonsterScoreCsReq());

		// Token: 0x040055F4 RID: 22004
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055F5 RID: 22005
		public const int MHEIIMDJKLCFieldNumber = 2;

		// Token: 0x040055F6 RID: 22006
		private bool mHEIIMDJKLC_;

		// Token: 0x040055F7 RID: 22007
		public const int LEHPJLFNONEFieldNumber = 8;

		// Token: 0x040055F8 RID: 22008
		private PunkLordMonsterKey lEHPJLFNONE_;
	}
}
