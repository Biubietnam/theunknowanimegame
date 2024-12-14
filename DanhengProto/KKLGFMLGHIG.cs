using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009BD RID: 2493
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KKLGFMLGHIG : IMessage<KKLGFMLGHIG>, IMessage, IEquatable<KKLGFMLGHIG>, IDeepCloneable<KKLGFMLGHIG>, IBufferMessage
	{
		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x06006F54 RID: 28500 RVA: 0x001293B4 File Offset: 0x001275B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KKLGFMLGHIG> Parser
		{
			get
			{
				return KKLGFMLGHIG._parser;
			}
		}

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x06006F55 RID: 28501 RVA: 0x001293BB File Offset: 0x001275BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KKLGFMLGHIGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x06006F56 RID: 28502 RVA: 0x001293CD File Offset: 0x001275CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KKLGFMLGHIG.Descriptor;
			}
		}

		// Token: 0x06006F57 RID: 28503 RVA: 0x001293D4 File Offset: 0x001275D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KKLGFMLGHIG()
		{
		}

		// Token: 0x06006F58 RID: 28504 RVA: 0x001293DC File Offset: 0x001275DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KKLGFMLGHIG(KKLGFMLGHIG other) : this()
		{
			this.hKNLFLIJEGA_ = other.hKNLFLIJEGA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F59 RID: 28505 RVA: 0x00129401 File Offset: 0x00127601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KKLGFMLGHIG Clone()
		{
			return new KKLGFMLGHIG(this);
		}

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x06006F5A RID: 28506 RVA: 0x00129409 File Offset: 0x00127609
		// (set) Token: 0x06006F5B RID: 28507 RVA: 0x00129411 File Offset: 0x00127611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HKNLFLIJEGA
		{
			get
			{
				return this.hKNLFLIJEGA_;
			}
			set
			{
				this.hKNLFLIJEGA_ = value;
			}
		}

		// Token: 0x06006F5C RID: 28508 RVA: 0x0012941A File Offset: 0x0012761A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KKLGFMLGHIG);
		}

		// Token: 0x06006F5D RID: 28509 RVA: 0x00129428 File Offset: 0x00127628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KKLGFMLGHIG other)
		{
			return other != null && (other == this || (this.HKNLFLIJEGA == other.HKNLFLIJEGA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F5E RID: 28510 RVA: 0x00129458 File Offset: 0x00127658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HKNLFLIJEGA != 0)
			{
				num ^= this.HKNLFLIJEGA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F5F RID: 28511 RVA: 0x00129497 File Offset: 0x00127697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006F60 RID: 28512 RVA: 0x0012949F File Offset: 0x0012769F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F61 RID: 28513 RVA: 0x001294A8 File Offset: 0x001276A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HKNLFLIJEGA != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.HKNLFLIJEGA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F62 RID: 28514 RVA: 0x001294DC File Offset: 0x001276DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HKNLFLIJEGA != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HKNLFLIJEGA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F63 RID: 28515 RVA: 0x0012951A File Offset: 0x0012771A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KKLGFMLGHIG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HKNLFLIJEGA != 0)
			{
				this.HKNLFLIJEGA = other.HKNLFLIJEGA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F64 RID: 28516 RVA: 0x0012954B File Offset: 0x0012774B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F65 RID: 28517 RVA: 0x00129554 File Offset: 0x00127754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HKNLFLIJEGA = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002AC9 RID: 10953
		private static readonly MessageParser<KKLGFMLGHIG> _parser = new MessageParser<KKLGFMLGHIG>(() => new KKLGFMLGHIG());

		// Token: 0x04002ACA RID: 10954
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002ACB RID: 10955
		public const int HKNLFLIJEGAFieldNumber = 9;

		// Token: 0x04002ACC RID: 10956
		private int hKNLFLIJEGA_;
	}
}
