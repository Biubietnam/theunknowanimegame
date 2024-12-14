using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000337 RID: 823
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class COOCBDAINLK : IMessage<COOCBDAINLK>, IMessage, IEquatable<COOCBDAINLK>, IDeepCloneable<COOCBDAINLK>, IBufferMessage
	{
		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x00067E5C File Offset: 0x0006605C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<COOCBDAINLK> Parser
		{
			get
			{
				return COOCBDAINLK._parser;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x060024C9 RID: 9417 RVA: 0x00067E63 File Offset: 0x00066063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return COOCBDAINLKReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x00067E75 File Offset: 0x00066075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return COOCBDAINLK.Descriptor;
			}
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x00067E7C File Offset: 0x0006607C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public COOCBDAINLK()
		{
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00067E8F File Offset: 0x0006608F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public COOCBDAINLK(COOCBDAINLK other) : this()
		{
			this.miracleList_ = other.miracleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x00067EB9 File Offset: 0x000660B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public COOCBDAINLK Clone()
		{
			return new COOCBDAINLK(this);
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x060024CE RID: 9422 RVA: 0x00067EC1 File Offset: 0x000660C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IPICDPBDHBJ> MiracleList
		{
			get
			{
				return this.miracleList_;
			}
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x00067EC9 File Offset: 0x000660C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as COOCBDAINLK);
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x00067ED7 File Offset: 0x000660D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(COOCBDAINLK other)
		{
			return other != null && (other == this || (this.miracleList_.Equals(other.miracleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00067F0C File Offset: 0x0006610C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.miracleList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x00067F40 File Offset: 0x00066140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x00067F48 File Offset: 0x00066148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x00067F51 File Offset: 0x00066151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.miracleList_.WriteTo(ref output, COOCBDAINLK._repeated_miracleList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x00067F78 File Offset: 0x00066178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.miracleList_.CalculateSize(COOCBDAINLK._repeated_miracleList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x00067FB1 File Offset: 0x000661B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(COOCBDAINLK other)
		{
			if (other == null)
			{
				return;
			}
			this.miracleList_.Add(other.miracleList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x00067FDF File Offset: 0x000661DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x00067FE8 File Offset: 0x000661E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.miracleList_.AddEntriesFrom(ref input, COOCBDAINLK._repeated_miracleList_codec);
				}
			}
		}

		// Token: 0x04000F00 RID: 3840
		private static readonly MessageParser<COOCBDAINLK> _parser = new MessageParser<COOCBDAINLK>(() => new COOCBDAINLK());

		// Token: 0x04000F01 RID: 3841
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F02 RID: 3842
		public const int MiracleListFieldNumber = 8;

		// Token: 0x04000F03 RID: 3843
		private static readonly FieldCodec<IPICDPBDHBJ> _repeated_miracleList_codec = FieldCodec.ForMessage<IPICDPBDHBJ>(66U, IPICDPBDHBJ.Parser);

		// Token: 0x04000F04 RID: 3844
		private readonly RepeatedField<IPICDPBDHBJ> miracleList_ = new RepeatedField<IPICDPBDHBJ>();
	}
}
