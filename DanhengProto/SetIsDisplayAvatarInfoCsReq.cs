using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001109 RID: 4361
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetIsDisplayAvatarInfoCsReq : IMessage<SetIsDisplayAvatarInfoCsReq>, IMessage, IEquatable<SetIsDisplayAvatarInfoCsReq>, IDeepCloneable<SetIsDisplayAvatarInfoCsReq>, IBufferMessage
	{
		// Token: 0x170036DA RID: 14042
		// (get) Token: 0x0600C275 RID: 49781 RVA: 0x0020A5A8 File Offset: 0x002087A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetIsDisplayAvatarInfoCsReq> Parser
		{
			get
			{
				return SetIsDisplayAvatarInfoCsReq._parser;
			}
		}

		// Token: 0x170036DB RID: 14043
		// (get) Token: 0x0600C276 RID: 49782 RVA: 0x0020A5AF File Offset: 0x002087AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetIsDisplayAvatarInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036DC RID: 14044
		// (get) Token: 0x0600C277 RID: 49783 RVA: 0x0020A5C1 File Offset: 0x002087C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetIsDisplayAvatarInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600C278 RID: 49784 RVA: 0x0020A5C8 File Offset: 0x002087C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetIsDisplayAvatarInfoCsReq()
		{
		}

		// Token: 0x0600C279 RID: 49785 RVA: 0x0020A5D0 File Offset: 0x002087D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetIsDisplayAvatarInfoCsReq(SetIsDisplayAvatarInfoCsReq other) : this()
		{
			this.isDisplay_ = other.isDisplay_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C27A RID: 49786 RVA: 0x0020A5F5 File Offset: 0x002087F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetIsDisplayAvatarInfoCsReq Clone()
		{
			return new SetIsDisplayAvatarInfoCsReq(this);
		}

		// Token: 0x170036DD RID: 14045
		// (get) Token: 0x0600C27B RID: 49787 RVA: 0x0020A5FD File Offset: 0x002087FD
		// (set) Token: 0x0600C27C RID: 49788 RVA: 0x0020A605 File Offset: 0x00208805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDisplay
		{
			get
			{
				return this.isDisplay_;
			}
			set
			{
				this.isDisplay_ = value;
			}
		}

		// Token: 0x0600C27D RID: 49789 RVA: 0x0020A60E File Offset: 0x0020880E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetIsDisplayAvatarInfoCsReq);
		}

		// Token: 0x0600C27E RID: 49790 RVA: 0x0020A61C File Offset: 0x0020881C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetIsDisplayAvatarInfoCsReq other)
		{
			return other != null && (other == this || (this.IsDisplay == other.IsDisplay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C27F RID: 49791 RVA: 0x0020A64C File Offset: 0x0020884C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsDisplay)
			{
				num ^= this.IsDisplay.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C280 RID: 49792 RVA: 0x0020A68B File Offset: 0x0020888B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C281 RID: 49793 RVA: 0x0020A693 File Offset: 0x00208893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C282 RID: 49794 RVA: 0x0020A69C File Offset: 0x0020889C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsDisplay)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsDisplay);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C283 RID: 49795 RVA: 0x0020A6D0 File Offset: 0x002088D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsDisplay)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C284 RID: 49796 RVA: 0x0020A702 File Offset: 0x00208902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetIsDisplayAvatarInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsDisplay)
			{
				this.IsDisplay = other.IsDisplay;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C285 RID: 49797 RVA: 0x0020A733 File Offset: 0x00208933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C286 RID: 49798 RVA: 0x0020A73C File Offset: 0x0020893C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsDisplay = input.ReadBool();
				}
			}
		}

		// Token: 0x04004EAA RID: 20138
		private static readonly MessageParser<SetIsDisplayAvatarInfoCsReq> _parser = new MessageParser<SetIsDisplayAvatarInfoCsReq>(() => new SetIsDisplayAvatarInfoCsReq());

		// Token: 0x04004EAB RID: 20139
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EAC RID: 20140
		public const int IsDisplayFieldNumber = 12;

		// Token: 0x04004EAD RID: 20141
		private bool isDisplay_;
	}
}
