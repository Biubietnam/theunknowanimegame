using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004F3 RID: 1267
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExtraLineupDestroyNotify : IMessage<ExtraLineupDestroyNotify>, IMessage, IEquatable<ExtraLineupDestroyNotify>, IDeepCloneable<ExtraLineupDestroyNotify>, IBufferMessage
	{
		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x060038B3 RID: 14515 RVA: 0x0009B725 File Offset: 0x00099925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExtraLineupDestroyNotify> Parser
		{
			get
			{
				return ExtraLineupDestroyNotify._parser;
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x060038B4 RID: 14516 RVA: 0x0009B72C File Offset: 0x0009992C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExtraLineupDestroyNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x060038B5 RID: 14517 RVA: 0x0009B73E File Offset: 0x0009993E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExtraLineupDestroyNotify.Descriptor;
			}
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x0009B745 File Offset: 0x00099945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraLineupDestroyNotify()
		{
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x0009B74D File Offset: 0x0009994D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraLineupDestroyNotify(ExtraLineupDestroyNotify other) : this()
		{
			this.extraLineupType_ = other.extraLineupType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x0009B772 File Offset: 0x00099972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraLineupDestroyNotify Clone()
		{
			return new ExtraLineupDestroyNotify(this);
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x060038B9 RID: 14521 RVA: 0x0009B77A File Offset: 0x0009997A
		// (set) Token: 0x060038BA RID: 14522 RVA: 0x0009B782 File Offset: 0x00099982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraLineupType ExtraLineupType
		{
			get
			{
				return this.extraLineupType_;
			}
			set
			{
				this.extraLineupType_ = value;
			}
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x0009B78B File Offset: 0x0009998B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExtraLineupDestroyNotify);
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x0009B799 File Offset: 0x00099999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExtraLineupDestroyNotify other)
		{
			return other != null && (other == this || (this.ExtraLineupType == other.ExtraLineupType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x0009B7C8 File Offset: 0x000999C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				num ^= this.ExtraLineupType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x0009B80D File Offset: 0x00099A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x0009B815 File Offset: 0x00099A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x0009B81E File Offset: 0x00099A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ExtraLineupType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x0009B850 File Offset: 0x00099A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ExtraLineupType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x0009B88E File Offset: 0x00099A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExtraLineupDestroyNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				this.ExtraLineupType = other.ExtraLineupType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x0009B8BF File Offset: 0x00099ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x0009B8C8 File Offset: 0x00099AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ExtraLineupType = (ExtraLineupType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04001670 RID: 5744
		private static readonly MessageParser<ExtraLineupDestroyNotify> _parser = new MessageParser<ExtraLineupDestroyNotify>(() => new ExtraLineupDestroyNotify());

		// Token: 0x04001671 RID: 5745
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001672 RID: 5746
		public const int ExtraLineupTypeFieldNumber = 1;

		// Token: 0x04001673 RID: 5747
		private ExtraLineupType extraLineupType_;
	}
}
