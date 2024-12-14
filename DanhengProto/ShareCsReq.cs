using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001143 RID: 4419
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShareCsReq : IMessage<ShareCsReq>, IMessage, IEquatable<ShareCsReq>, IDeepCloneable<ShareCsReq>, IBufferMessage
	{
		// Token: 0x17003795 RID: 14229
		// (get) Token: 0x0600C51B RID: 50459 RVA: 0x00211044 File Offset: 0x0020F244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShareCsReq> Parser
		{
			get
			{
				return ShareCsReq._parser;
			}
		}

		// Token: 0x17003796 RID: 14230
		// (get) Token: 0x0600C51C RID: 50460 RVA: 0x0021104B File Offset: 0x0020F24B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ShareCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x0600C51D RID: 50461 RVA: 0x0021105D File Offset: 0x0020F25D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShareCsReq.Descriptor;
			}
		}

		// Token: 0x0600C51E RID: 50462 RVA: 0x00211064 File Offset: 0x0020F264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShareCsReq()
		{
		}

		// Token: 0x0600C51F RID: 50463 RVA: 0x0021106C File Offset: 0x0020F26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShareCsReq(ShareCsReq other) : this()
		{
			this.pBDKOKELGHL_ = other.pBDKOKELGHL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C520 RID: 50464 RVA: 0x00211091 File Offset: 0x0020F291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShareCsReq Clone()
		{
			return new ShareCsReq(this);
		}

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x0600C521 RID: 50465 RVA: 0x00211099 File Offset: 0x0020F299
		// (set) Token: 0x0600C522 RID: 50466 RVA: 0x002110A1 File Offset: 0x0020F2A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PBDKOKELGHL
		{
			get
			{
				return this.pBDKOKELGHL_;
			}
			set
			{
				this.pBDKOKELGHL_ = value;
			}
		}

		// Token: 0x0600C523 RID: 50467 RVA: 0x002110AA File Offset: 0x0020F2AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShareCsReq);
		}

		// Token: 0x0600C524 RID: 50468 RVA: 0x002110B8 File Offset: 0x0020F2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShareCsReq other)
		{
			return other != null && (other == this || (this.PBDKOKELGHL == other.PBDKOKELGHL && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C525 RID: 50469 RVA: 0x002110E8 File Offset: 0x0020F2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PBDKOKELGHL != 0U)
			{
				num ^= this.PBDKOKELGHL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C526 RID: 50470 RVA: 0x00211127 File Offset: 0x0020F327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C527 RID: 50471 RVA: 0x0021112F File Offset: 0x0020F32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C528 RID: 50472 RVA: 0x00211138 File Offset: 0x0020F338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PBDKOKELGHL != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.PBDKOKELGHL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C529 RID: 50473 RVA: 0x0021116C File Offset: 0x0020F36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PBDKOKELGHL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PBDKOKELGHL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C52A RID: 50474 RVA: 0x002111AA File Offset: 0x0020F3AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShareCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PBDKOKELGHL != 0U)
			{
				this.PBDKOKELGHL = other.PBDKOKELGHL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C52B RID: 50475 RVA: 0x002111DB File Offset: 0x0020F3DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C52C RID: 50476 RVA: 0x002111E4 File Offset: 0x0020F3E4
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
					this.PBDKOKELGHL = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004F9E RID: 20382
		private static readonly MessageParser<ShareCsReq> _parser = new MessageParser<ShareCsReq>(() => new ShareCsReq());

		// Token: 0x04004F9F RID: 20383
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FA0 RID: 20384
		public const int PBDKOKELGHLFieldNumber = 9;

		// Token: 0x04004FA1 RID: 20385
		private uint pBDKOKELGHL_;
	}
}
