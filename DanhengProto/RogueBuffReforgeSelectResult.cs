using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E21 RID: 3617
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueBuffReforgeSelectResult : IMessage<RogueBuffReforgeSelectResult>, IMessage, IEquatable<RogueBuffReforgeSelectResult>, IDeepCloneable<RogueBuffReforgeSelectResult>, IBufferMessage
	{
		// Token: 0x17002D94 RID: 11668
		// (get) Token: 0x0600A183 RID: 41347 RVA: 0x001B0DE4 File Offset: 0x001AEFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueBuffReforgeSelectResult> Parser
		{
			get
			{
				return RogueBuffReforgeSelectResult._parser;
			}
		}

		// Token: 0x17002D95 RID: 11669
		// (get) Token: 0x0600A184 RID: 41348 RVA: 0x001B0DEB File Offset: 0x001AEFEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueBuffReforgeSelectResultReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D96 RID: 11670
		// (get) Token: 0x0600A185 RID: 41349 RVA: 0x001B0DFD File Offset: 0x001AEFFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBuffReforgeSelectResult.Descriptor;
			}
		}

		// Token: 0x0600A186 RID: 41350 RVA: 0x001B0E04 File Offset: 0x001AF004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffReforgeSelectResult()
		{
		}

		// Token: 0x0600A187 RID: 41351 RVA: 0x001B0E0C File Offset: 0x001AF00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffReforgeSelectResult(RogueBuffReforgeSelectResult other) : this()
		{
			this.buffSelectId_ = other.buffSelectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A188 RID: 41352 RVA: 0x001B0E31 File Offset: 0x001AF031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffReforgeSelectResult Clone()
		{
			return new RogueBuffReforgeSelectResult(this);
		}

		// Token: 0x17002D97 RID: 11671
		// (get) Token: 0x0600A189 RID: 41353 RVA: 0x001B0E39 File Offset: 0x001AF039
		// (set) Token: 0x0600A18A RID: 41354 RVA: 0x001B0E41 File Offset: 0x001AF041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffSelectId
		{
			get
			{
				return this.buffSelectId_;
			}
			set
			{
				this.buffSelectId_ = value;
			}
		}

		// Token: 0x0600A18B RID: 41355 RVA: 0x001B0E4A File Offset: 0x001AF04A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBuffReforgeSelectResult);
		}

		// Token: 0x0600A18C RID: 41356 RVA: 0x001B0E58 File Offset: 0x001AF058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBuffReforgeSelectResult other)
		{
			return other != null && (other == this || (this.BuffSelectId == other.BuffSelectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A18D RID: 41357 RVA: 0x001B0E88 File Offset: 0x001AF088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffSelectId != 0U)
			{
				num ^= this.BuffSelectId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A18E RID: 41358 RVA: 0x001B0EC7 File Offset: 0x001AF0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A18F RID: 41359 RVA: 0x001B0ECF File Offset: 0x001AF0CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A190 RID: 41360 RVA: 0x001B0ED8 File Offset: 0x001AF0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffSelectId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.BuffSelectId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A191 RID: 41361 RVA: 0x001B0F0C File Offset: 0x001AF10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffSelectId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffSelectId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A192 RID: 41362 RVA: 0x001B0F4A File Offset: 0x001AF14A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBuffReforgeSelectResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffSelectId != 0U)
			{
				this.BuffSelectId = other.BuffSelectId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A193 RID: 41363 RVA: 0x001B0F7B File Offset: 0x001AF17B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A194 RID: 41364 RVA: 0x001B0F84 File Offset: 0x001AF184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BuffSelectId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004215 RID: 16917
		private static readonly MessageParser<RogueBuffReforgeSelectResult> _parser = new MessageParser<RogueBuffReforgeSelectResult>(() => new RogueBuffReforgeSelectResult());

		// Token: 0x04004216 RID: 16918
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004217 RID: 16919
		public const int BuffSelectIdFieldNumber = 2;

		// Token: 0x04004218 RID: 16920
		private uint buffSelectId_;
	}
}
