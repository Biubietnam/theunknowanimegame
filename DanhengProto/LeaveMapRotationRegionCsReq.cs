using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009F5 RID: 2549
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LeaveMapRotationRegionCsReq : IMessage<LeaveMapRotationRegionCsReq>, IMessage, IEquatable<LeaveMapRotationRegionCsReq>, IDeepCloneable<LeaveMapRotationRegionCsReq>, IBufferMessage
	{
		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x06007124 RID: 28964 RVA: 0x0012D521 File Offset: 0x0012B721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LeaveMapRotationRegionCsReq> Parser
		{
			get
			{
				return LeaveMapRotationRegionCsReq._parser;
			}
		}

		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x06007125 RID: 28965 RVA: 0x0012D528 File Offset: 0x0012B728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaveMapRotationRegionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x06007126 RID: 28966 RVA: 0x0012D53A File Offset: 0x0012B73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveMapRotationRegionCsReq.Descriptor;
			}
		}

		// Token: 0x06007127 RID: 28967 RVA: 0x0012D541 File Offset: 0x0012B741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMapRotationRegionCsReq()
		{
		}

		// Token: 0x06007128 RID: 28968 RVA: 0x0012D549 File Offset: 0x0012B749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMapRotationRegionCsReq(LeaveMapRotationRegionCsReq other) : this()
		{
			this.motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007129 RID: 28969 RVA: 0x0012D57E File Offset: 0x0012B77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMapRotationRegionCsReq Clone()
		{
			return new LeaveMapRotationRegionCsReq(this);
		}

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x0600712A RID: 28970 RVA: 0x0012D586 File Offset: 0x0012B786
		// (set) Token: 0x0600712B RID: 28971 RVA: 0x0012D58E File Offset: 0x0012B78E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotionInfo Motion
		{
			get
			{
				return this.motion_;
			}
			set
			{
				this.motion_ = value;
			}
		}

		// Token: 0x0600712C RID: 28972 RVA: 0x0012D597 File Offset: 0x0012B797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveMapRotationRegionCsReq);
		}

		// Token: 0x0600712D RID: 28973 RVA: 0x0012D5A5 File Offset: 0x0012B7A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveMapRotationRegionCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.Motion, other.Motion) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600712E RID: 28974 RVA: 0x0012D5D8 File Offset: 0x0012B7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.motion_ != null)
			{
				num ^= this.Motion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600712F RID: 28975 RVA: 0x0012D614 File Offset: 0x0012B814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007130 RID: 28976 RVA: 0x0012D61C File Offset: 0x0012B81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007131 RID: 28977 RVA: 0x0012D625 File Offset: 0x0012B825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motion_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Motion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007132 RID: 28978 RVA: 0x0012D658 File Offset: 0x0012B858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.motion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Motion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007133 RID: 28979 RVA: 0x0012D698 File Offset: 0x0012B898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveMapRotationRegionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.motion_ != null)
			{
				if (this.motion_ == null)
				{
					this.Motion = new MotionInfo();
				}
				this.Motion.MergeFrom(other.Motion);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007134 RID: 28980 RVA: 0x0012D6EC File Offset: 0x0012B8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007135 RID: 28981 RVA: 0x0012D6F8 File Offset: 0x0012B8F8
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
					if (this.motion_ == null)
					{
						this.Motion = new MotionInfo();
					}
					input.ReadMessage(this.Motion);
				}
			}
		}

		// Token: 0x04002B8F RID: 11151
		private static readonly MessageParser<LeaveMapRotationRegionCsReq> _parser = new MessageParser<LeaveMapRotationRegionCsReq>(() => new LeaveMapRotationRegionCsReq());

		// Token: 0x04002B90 RID: 11152
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B91 RID: 11153
		public const int MotionFieldNumber = 8;

		// Token: 0x04002B92 RID: 11154
		private MotionInfo motion_;
	}
}
