using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000333 RID: 819
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContentPackageUnlockCsReq : IMessage<ContentPackageUnlockCsReq>, IMessage, IEquatable<ContentPackageUnlockCsReq>, IDeepCloneable<ContentPackageUnlockCsReq>, IBufferMessage
	{
		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x0600249C RID: 9372 RVA: 0x000678AC File Offset: 0x00065AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContentPackageUnlockCsReq> Parser
		{
			get
			{
				return ContentPackageUnlockCsReq._parser;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x000678B3 File Offset: 0x00065AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ContentPackageUnlockCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x0600249E RID: 9374 RVA: 0x000678C5 File Offset: 0x00065AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ContentPackageUnlockCsReq.Descriptor;
			}
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x000678CC File Offset: 0x00065ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageUnlockCsReq()
		{
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x000678D4 File Offset: 0x00065AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageUnlockCsReq(ContentPackageUnlockCsReq other) : this()
		{
			this.contentId_ = other.contentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x000678F9 File Offset: 0x00065AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageUnlockCsReq Clone()
		{
			return new ContentPackageUnlockCsReq(this);
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x00067901 File Offset: 0x00065B01
		// (set) Token: 0x060024A3 RID: 9379 RVA: 0x00067909 File Offset: 0x00065B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ContentId
		{
			get
			{
				return this.contentId_;
			}
			set
			{
				this.contentId_ = value;
			}
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x00067912 File Offset: 0x00065B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ContentPackageUnlockCsReq);
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x00067920 File Offset: 0x00065B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ContentPackageUnlockCsReq other)
		{
			return other != null && (other == this || (this.ContentId == other.ContentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x00067950 File Offset: 0x00065B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContentId != 0U)
			{
				num ^= this.ContentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x0006798F File Offset: 0x00065B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x00067997 File Offset: 0x00065B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x000679A0 File Offset: 0x00065BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContentId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ContentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x000679D4 File Offset: 0x00065BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ContentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x00067A12 File Offset: 0x00065C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ContentPackageUnlockCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContentId != 0U)
			{
				this.ContentId = other.ContentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x00067A43 File Offset: 0x00065C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x00067A4C File Offset: 0x00065C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ContentId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000EF4 RID: 3828
		private static readonly MessageParser<ContentPackageUnlockCsReq> _parser = new MessageParser<ContentPackageUnlockCsReq>(() => new ContentPackageUnlockCsReq());

		// Token: 0x04000EF5 RID: 3829
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EF6 RID: 3830
		public const int ContentIdFieldNumber = 15;

		// Token: 0x04000EF7 RID: 3831
		private uint contentId_;
	}
}
