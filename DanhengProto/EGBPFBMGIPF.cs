using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003FB RID: 1019
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EGBPFBMGIPF : IMessage<EGBPFBMGIPF>, IMessage, IEquatable<EGBPFBMGIPF>, IDeepCloneable<EGBPFBMGIPF>, IBufferMessage
	{
		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x06002D43 RID: 11587 RVA: 0x0007D2D4 File Offset: 0x0007B4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EGBPFBMGIPF> Parser
		{
			get
			{
				return EGBPFBMGIPF._parser;
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x0007D2DB File Offset: 0x0007B4DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EGBPFBMGIPFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x0007D2ED File Offset: 0x0007B4ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EGBPFBMGIPF.Descriptor;
			}
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x0007D2F4 File Offset: 0x0007B4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EGBPFBMGIPF()
		{
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x0007D2FC File Offset: 0x0007B4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EGBPFBMGIPF(EGBPFBMGIPF other) : this()
		{
			this.areaId_ = other.areaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x0007D321 File Offset: 0x0007B521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EGBPFBMGIPF Clone()
		{
			return new EGBPFBMGIPF(this);
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06002D49 RID: 11593 RVA: 0x0007D329 File Offset: 0x0007B529
		// (set) Token: 0x06002D4A RID: 11594 RVA: 0x0007D331 File Offset: 0x0007B531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x0007D33A File Offset: 0x0007B53A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EGBPFBMGIPF);
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x0007D348 File Offset: 0x0007B548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EGBPFBMGIPF other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x0007D378 File Offset: 0x0007B578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x0007D3B7 File Offset: 0x0007B5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x0007D3BF File Offset: 0x0007B5BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x0007D3C8 File Offset: 0x0007B5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x0007D3FC File Offset: 0x0007B5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x0007D43A File Offset: 0x0007B63A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EGBPFBMGIPF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x0007D46B File Offset: 0x0007B66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x0007D474 File Offset: 0x0007B674
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
					this.AreaId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001238 RID: 4664
		private static readonly MessageParser<EGBPFBMGIPF> _parser = new MessageParser<EGBPFBMGIPF>(() => new EGBPFBMGIPF());

		// Token: 0x04001239 RID: 4665
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400123A RID: 4666
		public const int AreaIdFieldNumber = 4;

		// Token: 0x0400123B RID: 4667
		private uint areaId_;
	}
}
