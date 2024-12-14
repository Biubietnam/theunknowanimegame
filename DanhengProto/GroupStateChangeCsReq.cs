using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200087B RID: 2171
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GroupStateChangeCsReq : IMessage<GroupStateChangeCsReq>, IMessage, IEquatable<GroupStateChangeCsReq>, IDeepCloneable<GroupStateChangeCsReq>, IBufferMessage
	{
		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x0600608A RID: 24714 RVA: 0x000FF491 File Offset: 0x000FD691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GroupStateChangeCsReq> Parser
		{
			get
			{
				return GroupStateChangeCsReq._parser;
			}
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x0600608B RID: 24715 RVA: 0x000FF498 File Offset: 0x000FD698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GroupStateChangeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x0600608C RID: 24716 RVA: 0x000FF4AA File Offset: 0x000FD6AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GroupStateChangeCsReq.Descriptor;
			}
		}

		// Token: 0x0600608D RID: 24717 RVA: 0x000FF4B1 File Offset: 0x000FD6B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStateChangeCsReq()
		{
		}

		// Token: 0x0600608E RID: 24718 RVA: 0x000FF4B9 File Offset: 0x000FD6B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStateChangeCsReq(GroupStateChangeCsReq other) : this()
		{
			this.groupStateInfo_ = ((other.groupStateInfo_ != null) ? other.groupStateInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600608F RID: 24719 RVA: 0x000FF4EE File Offset: 0x000FD6EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStateChangeCsReq Clone()
		{
			return new GroupStateChangeCsReq(this);
		}

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x06006090 RID: 24720 RVA: 0x000FF4F6 File Offset: 0x000FD6F6
		// (set) Token: 0x06006091 RID: 24721 RVA: 0x000FF4FE File Offset: 0x000FD6FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStateInfo GroupStateInfo
		{
			get
			{
				return this.groupStateInfo_;
			}
			set
			{
				this.groupStateInfo_ = value;
			}
		}

		// Token: 0x06006092 RID: 24722 RVA: 0x000FF507 File Offset: 0x000FD707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GroupStateChangeCsReq);
		}

		// Token: 0x06006093 RID: 24723 RVA: 0x000FF515 File Offset: 0x000FD715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GroupStateChangeCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.GroupStateInfo, other.GroupStateInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x000FF548 File Offset: 0x000FD748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.groupStateInfo_ != null)
			{
				num ^= this.GroupStateInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006095 RID: 24725 RVA: 0x000FF584 File Offset: 0x000FD784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006096 RID: 24726 RVA: 0x000FF58C File Offset: 0x000FD78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006097 RID: 24727 RVA: 0x000FF595 File Offset: 0x000FD795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.groupStateInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.GroupStateInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006098 RID: 24728 RVA: 0x000FF5C8 File Offset: 0x000FD7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.groupStateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GroupStateInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006099 RID: 24729 RVA: 0x000FF608 File Offset: 0x000FD808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GroupStateChangeCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.groupStateInfo_ != null)
			{
				if (this.groupStateInfo_ == null)
				{
					this.GroupStateInfo = new GroupStateInfo();
				}
				this.GroupStateInfo.MergeFrom(other.GroupStateInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600609A RID: 24730 RVA: 0x000FF65C File Offset: 0x000FD85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600609B RID: 24731 RVA: 0x000FF668 File Offset: 0x000FD868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.groupStateInfo_ == null)
					{
						this.GroupStateInfo = new GroupStateInfo();
					}
					input.ReadMessage(this.GroupStateInfo);
				}
			}
		}

		// Token: 0x04002520 RID: 9504
		private static readonly MessageParser<GroupStateChangeCsReq> _parser = new MessageParser<GroupStateChangeCsReq>(() => new GroupStateChangeCsReq());

		// Token: 0x04002521 RID: 9505
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002522 RID: 9506
		public const int GroupStateInfoFieldNumber = 15;

		// Token: 0x04002523 RID: 9507
		private GroupStateInfo groupStateInfo_;
	}
}
