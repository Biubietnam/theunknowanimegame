using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001219 RID: 4633
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwitchLineupIndexCsReq : IMessage<SwitchLineupIndexCsReq>, IMessage, IEquatable<SwitchLineupIndexCsReq>, IDeepCloneable<SwitchLineupIndexCsReq>, IBufferMessage
	{
		// Token: 0x17003A64 RID: 14948
		// (get) Token: 0x0600CF16 RID: 53014 RVA: 0x0022B3F0 File Offset: 0x002295F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwitchLineupIndexCsReq> Parser
		{
			get
			{
				return SwitchLineupIndexCsReq._parser;
			}
		}

		// Token: 0x17003A65 RID: 14949
		// (get) Token: 0x0600CF17 RID: 53015 RVA: 0x0022B3F7 File Offset: 0x002295F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwitchLineupIndexCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A66 RID: 14950
		// (get) Token: 0x0600CF18 RID: 53016 RVA: 0x0022B409 File Offset: 0x00229609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchLineupIndexCsReq.Descriptor;
			}
		}

		// Token: 0x0600CF19 RID: 53017 RVA: 0x0022B410 File Offset: 0x00229610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLineupIndexCsReq()
		{
		}

		// Token: 0x0600CF1A RID: 53018 RVA: 0x0022B418 File Offset: 0x00229618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLineupIndexCsReq(SwitchLineupIndexCsReq other) : this()
		{
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF1B RID: 53019 RVA: 0x0022B43D File Offset: 0x0022963D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLineupIndexCsReq Clone()
		{
			return new SwitchLineupIndexCsReq(this);
		}

		// Token: 0x17003A67 RID: 14951
		// (get) Token: 0x0600CF1C RID: 53020 RVA: 0x0022B445 File Offset: 0x00229645
		// (set) Token: 0x0600CF1D RID: 53021 RVA: 0x0022B44D File Offset: 0x0022964D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0600CF1E RID: 53022 RVA: 0x0022B456 File Offset: 0x00229656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchLineupIndexCsReq);
		}

		// Token: 0x0600CF1F RID: 53023 RVA: 0x0022B464 File Offset: 0x00229664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchLineupIndexCsReq other)
		{
			return other != null && (other == this || (this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF20 RID: 53024 RVA: 0x0022B494 File Offset: 0x00229694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0U)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CF21 RID: 53025 RVA: 0x0022B4D3 File Offset: 0x002296D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CF22 RID: 53026 RVA: 0x0022B4DB File Offset: 0x002296DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF23 RID: 53027 RVA: 0x0022B4E4 File Offset: 0x002296E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF24 RID: 53028 RVA: 0x0022B518 File Offset: 0x00229718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CF25 RID: 53029 RVA: 0x0022B556 File Offset: 0x00229756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchLineupIndexCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0U)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF26 RID: 53030 RVA: 0x0022B587 File Offset: 0x00229787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF27 RID: 53031 RVA: 0x0022B590 File Offset: 0x00229790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Index = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400535C RID: 21340
		private static readonly MessageParser<SwitchLineupIndexCsReq> _parser = new MessageParser<SwitchLineupIndexCsReq>(() => new SwitchLineupIndexCsReq());

		// Token: 0x0400535D RID: 21341
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400535E RID: 21342
		public const int IndexFieldNumber = 13;

		// Token: 0x0400535F RID: 21343
		private uint index_;
	}
}
