using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D3F RID: 3391
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestRecord : IMessage<QuestRecord>, IMessage, IEquatable<QuestRecord>, IDeepCloneable<QuestRecord>, IBufferMessage
	{
		// Token: 0x17002ACE RID: 10958
		// (get) Token: 0x06009797 RID: 38807 RVA: 0x001941C4 File Offset: 0x001923C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestRecord> Parser
		{
			get
			{
				return QuestRecord._parser;
			}
		}

		// Token: 0x17002ACF RID: 10959
		// (get) Token: 0x06009798 RID: 38808 RVA: 0x001941CB File Offset: 0x001923CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuestRecordReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002AD0 RID: 10960
		// (get) Token: 0x06009799 RID: 38809 RVA: 0x001941DD File Offset: 0x001923DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestRecord.Descriptor;
			}
		}

		// Token: 0x0600979A RID: 38810 RVA: 0x001941E4 File Offset: 0x001923E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecord()
		{
		}

		// Token: 0x0600979B RID: 38811 RVA: 0x001941EC File Offset: 0x001923EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecord(QuestRecord other) : this()
		{
			this.oINCBGMPBIC_ = other.oINCBGMPBIC_;
			this.progress_ = other.progress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600979C RID: 38812 RVA: 0x0019421D File Offset: 0x0019241D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecord Clone()
		{
			return new QuestRecord(this);
		}

		// Token: 0x17002AD1 RID: 10961
		// (get) Token: 0x0600979D RID: 38813 RVA: 0x00194225 File Offset: 0x00192425
		// (set) Token: 0x0600979E RID: 38814 RVA: 0x0019422D File Offset: 0x0019242D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OINCBGMPBIC
		{
			get
			{
				return this.oINCBGMPBIC_;
			}
			set
			{
				this.oINCBGMPBIC_ = value;
			}
		}

		// Token: 0x17002AD2 RID: 10962
		// (get) Token: 0x0600979F RID: 38815 RVA: 0x00194236 File Offset: 0x00192436
		// (set) Token: 0x060097A0 RID: 38816 RVA: 0x0019423E File Offset: 0x0019243E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x060097A1 RID: 38817 RVA: 0x00194247 File Offset: 0x00192447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestRecord);
		}

		// Token: 0x060097A2 RID: 38818 RVA: 0x00194255 File Offset: 0x00192455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestRecord other)
		{
			return other != null && (other == this || (this.OINCBGMPBIC == other.OINCBGMPBIC && this.Progress == other.Progress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060097A3 RID: 38819 RVA: 0x00194294 File Offset: 0x00192494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OINCBGMPBIC != 0U)
			{
				num ^= this.OINCBGMPBIC.GetHashCode();
			}
			if (this.Progress != 0U)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060097A4 RID: 38820 RVA: 0x001942EC File Offset: 0x001924EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060097A5 RID: 38821 RVA: 0x001942F4 File Offset: 0x001924F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097A6 RID: 38822 RVA: 0x00194300 File Offset: 0x00192500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OINCBGMPBIC != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.OINCBGMPBIC);
			}
			if (this.Progress != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Progress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060097A7 RID: 38823 RVA: 0x0019435C File Offset: 0x0019255C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OINCBGMPBIC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OINCBGMPBIC);
			}
			if (this.Progress != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Progress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060097A8 RID: 38824 RVA: 0x001943B4 File Offset: 0x001925B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestRecord other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OINCBGMPBIC != 0U)
			{
				this.OINCBGMPBIC = other.OINCBGMPBIC;
			}
			if (other.Progress != 0U)
			{
				this.Progress = other.Progress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060097A9 RID: 38825 RVA: 0x00194404 File Offset: 0x00192604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097AA RID: 38826 RVA: 0x00194410 File Offset: 0x00192610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Progress = input.ReadUInt32();
					}
				}
				else
				{
					this.OINCBGMPBIC = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003AF7 RID: 15095
		private static readonly MessageParser<QuestRecord> _parser = new MessageParser<QuestRecord>(() => new QuestRecord());

		// Token: 0x04003AF8 RID: 15096
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AF9 RID: 15097
		public const int OINCBGMPBICFieldNumber = 3;

		// Token: 0x04003AFA RID: 15098
		private uint oINCBGMPBIC_;

		// Token: 0x04003AFB RID: 15099
		public const int ProgressFieldNumber = 15;

		// Token: 0x04003AFC RID: 15100
		private uint progress_;
	}
}
