using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003E7 RID: 999
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DrinkMakerUpdateTipsNotify : IMessage<DrinkMakerUpdateTipsNotify>, IMessage, IEquatable<DrinkMakerUpdateTipsNotify>, IDeepCloneable<DrinkMakerUpdateTipsNotify>, IBufferMessage
	{
		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x0007B5E0 File Offset: 0x000797E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DrinkMakerUpdateTipsNotify> Parser
		{
			get
			{
				return DrinkMakerUpdateTipsNotify._parser;
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x0007B5E7 File Offset: 0x000797E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DrinkMakerUpdateTipsNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06002C7A RID: 11386 RVA: 0x0007B5F9 File Offset: 0x000797F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrinkMakerUpdateTipsNotify.Descriptor;
			}
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x0007B600 File Offset: 0x00079800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMakerUpdateTipsNotify()
		{
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x0007B608 File Offset: 0x00079808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMakerUpdateTipsNotify(DrinkMakerUpdateTipsNotify other) : this()
		{
			this.bAAGLIIDLNK_ = other.bAAGLIIDLNK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x0007B62D File Offset: 0x0007982D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMakerUpdateTipsNotify Clone()
		{
			return new DrinkMakerUpdateTipsNotify(this);
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06002C7E RID: 11390 RVA: 0x0007B635 File Offset: 0x00079835
		// (set) Token: 0x06002C7F RID: 11391 RVA: 0x0007B63D File Offset: 0x0007983D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BAAGLIIDLNK
		{
			get
			{
				return this.bAAGLIIDLNK_;
			}
			set
			{
				this.bAAGLIIDLNK_ = value;
			}
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x0007B646 File Offset: 0x00079846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrinkMakerUpdateTipsNotify);
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x0007B654 File Offset: 0x00079854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrinkMakerUpdateTipsNotify other)
		{
			return other != null && (other == this || (this.BAAGLIIDLNK == other.BAAGLIIDLNK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x0007B684 File Offset: 0x00079884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BAAGLIIDLNK != 0U)
			{
				num ^= this.BAAGLIIDLNK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x0007B6C3 File Offset: 0x000798C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x0007B6CB File Offset: 0x000798CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x0007B6D4 File Offset: 0x000798D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BAAGLIIDLNK != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.BAAGLIIDLNK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x0007B708 File Offset: 0x00079908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BAAGLIIDLNK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BAAGLIIDLNK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x0007B746 File Offset: 0x00079946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrinkMakerUpdateTipsNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BAAGLIIDLNK != 0U)
			{
				this.BAAGLIIDLNK = other.BAAGLIIDLNK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x0007B777 File Offset: 0x00079977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x0007B780 File Offset: 0x00079980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BAAGLIIDLNK = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040011F2 RID: 4594
		private static readonly MessageParser<DrinkMakerUpdateTipsNotify> _parser = new MessageParser<DrinkMakerUpdateTipsNotify>(() => new DrinkMakerUpdateTipsNotify());

		// Token: 0x040011F3 RID: 4595
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011F4 RID: 4596
		public const int BAAGLIIDLNKFieldNumber = 4;

		// Token: 0x040011F5 RID: 4597
		private uint bAAGLIIDLNK_;
	}
}
