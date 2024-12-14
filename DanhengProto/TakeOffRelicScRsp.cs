using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001303 RID: 4867
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeOffRelicScRsp : IMessage<TakeOffRelicScRsp>, IMessage, IEquatable<TakeOffRelicScRsp>, IDeepCloneable<TakeOffRelicScRsp>, IBufferMessage
	{
		// Token: 0x17003D08 RID: 15624
		// (get) Token: 0x0600D927 RID: 55591 RVA: 0x00242DC0 File Offset: 0x00240FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeOffRelicScRsp> Parser
		{
			get
			{
				return TakeOffRelicScRsp._parser;
			}
		}

		// Token: 0x17003D09 RID: 15625
		// (get) Token: 0x0600D928 RID: 55592 RVA: 0x00242DC7 File Offset: 0x00240FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeOffRelicScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D0A RID: 15626
		// (get) Token: 0x0600D929 RID: 55593 RVA: 0x00242DD9 File Offset: 0x00240FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeOffRelicScRsp.Descriptor;
			}
		}

		// Token: 0x0600D92A RID: 55594 RVA: 0x00242DE0 File Offset: 0x00240FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffRelicScRsp()
		{
		}

		// Token: 0x0600D92B RID: 55595 RVA: 0x00242DE8 File Offset: 0x00240FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffRelicScRsp(TakeOffRelicScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D92C RID: 55596 RVA: 0x00242E0D File Offset: 0x0024100D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffRelicScRsp Clone()
		{
			return new TakeOffRelicScRsp(this);
		}

		// Token: 0x17003D0B RID: 15627
		// (get) Token: 0x0600D92D RID: 55597 RVA: 0x00242E15 File Offset: 0x00241015
		// (set) Token: 0x0600D92E RID: 55598 RVA: 0x00242E1D File Offset: 0x0024101D
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

		// Token: 0x0600D92F RID: 55599 RVA: 0x00242E26 File Offset: 0x00241026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeOffRelicScRsp);
		}

		// Token: 0x0600D930 RID: 55600 RVA: 0x00242E34 File Offset: 0x00241034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeOffRelicScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D931 RID: 55601 RVA: 0x00242E64 File Offset: 0x00241064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600D932 RID: 55602 RVA: 0x00242EA3 File Offset: 0x002410A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D933 RID: 55603 RVA: 0x00242EAB File Offset: 0x002410AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D934 RID: 55604 RVA: 0x00242EB4 File Offset: 0x002410B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D935 RID: 55605 RVA: 0x00242EE8 File Offset: 0x002410E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600D936 RID: 55606 RVA: 0x00242F26 File Offset: 0x00241126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeOffRelicScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D937 RID: 55607 RVA: 0x00242F57 File Offset: 0x00241157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D938 RID: 55608 RVA: 0x00242F60 File Offset: 0x00241160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005697 RID: 22167
		private static readonly MessageParser<TakeOffRelicScRsp> _parser = new MessageParser<TakeOffRelicScRsp>(() => new TakeOffRelicScRsp());

		// Token: 0x04005698 RID: 22168
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005699 RID: 22169
		public const int RetcodeFieldNumber = 3;

		// Token: 0x0400569A RID: 22170
		private uint retcode_;
	}
}
