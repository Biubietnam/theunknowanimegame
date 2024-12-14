using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C31 RID: 3121
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NpcMeetByPerformanceStatus : IMessage<NpcMeetByPerformanceStatus>, IMessage, IEquatable<NpcMeetByPerformanceStatus>, IDeepCloneable<NpcMeetByPerformanceStatus>, IBufferMessage
	{
		// Token: 0x170026CF RID: 9935
		// (get) Token: 0x06008A4D RID: 35405 RVA: 0x0016D399 File Offset: 0x0016B599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NpcMeetByPerformanceStatus> Parser
		{
			get
			{
				return NpcMeetByPerformanceStatus._parser;
			}
		}

		// Token: 0x170026D0 RID: 9936
		// (get) Token: 0x06008A4E RID: 35406 RVA: 0x0016D3A0 File Offset: 0x0016B5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NpcMeetByPerformanceStatusReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170026D1 RID: 9937
		// (get) Token: 0x06008A4F RID: 35407 RVA: 0x0016D3B2 File Offset: 0x0016B5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcMeetByPerformanceStatus.Descriptor;
			}
		}

		// Token: 0x06008A50 RID: 35408 RVA: 0x0016D3B9 File Offset: 0x0016B5B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcMeetByPerformanceStatus()
		{
		}

		// Token: 0x06008A51 RID: 35409 RVA: 0x0016D3C1 File Offset: 0x0016B5C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcMeetByPerformanceStatus(NpcMeetByPerformanceStatus other) : this()
		{
			this.isMeet_ = other.isMeet_;
			this.performanceId_ = other.performanceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A52 RID: 35410 RVA: 0x0016D3F2 File Offset: 0x0016B5F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcMeetByPerformanceStatus Clone()
		{
			return new NpcMeetByPerformanceStatus(this);
		}

		// Token: 0x170026D2 RID: 9938
		// (get) Token: 0x06008A53 RID: 35411 RVA: 0x0016D3FA File Offset: 0x0016B5FA
		// (set) Token: 0x06008A54 RID: 35412 RVA: 0x0016D402 File Offset: 0x0016B602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMeet
		{
			get
			{
				return this.isMeet_;
			}
			set
			{
				this.isMeet_ = value;
			}
		}

		// Token: 0x170026D3 RID: 9939
		// (get) Token: 0x06008A55 RID: 35413 RVA: 0x0016D40B File Offset: 0x0016B60B
		// (set) Token: 0x06008A56 RID: 35414 RVA: 0x0016D413 File Offset: 0x0016B613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PerformanceId
		{
			get
			{
				return this.performanceId_;
			}
			set
			{
				this.performanceId_ = value;
			}
		}

		// Token: 0x06008A57 RID: 35415 RVA: 0x0016D41C File Offset: 0x0016B61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcMeetByPerformanceStatus);
		}

		// Token: 0x06008A58 RID: 35416 RVA: 0x0016D42A File Offset: 0x0016B62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcMeetByPerformanceStatus other)
		{
			return other != null && (other == this || (this.IsMeet == other.IsMeet && this.PerformanceId == other.PerformanceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A59 RID: 35417 RVA: 0x0016D468 File Offset: 0x0016B668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsMeet)
			{
				num ^= this.IsMeet.GetHashCode();
			}
			if (this.PerformanceId != 0U)
			{
				num ^= this.PerformanceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A5A RID: 35418 RVA: 0x0016D4C0 File Offset: 0x0016B6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008A5B RID: 35419 RVA: 0x0016D4C8 File Offset: 0x0016B6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A5C RID: 35420 RVA: 0x0016D4D4 File Offset: 0x0016B6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsMeet)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsMeet);
			}
			if (this.PerformanceId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.PerformanceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A5D RID: 35421 RVA: 0x0016D530 File Offset: 0x0016B730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsMeet)
			{
				num += 2;
			}
			if (this.PerformanceId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PerformanceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A5E RID: 35422 RVA: 0x0016D57C File Offset: 0x0016B77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcMeetByPerformanceStatus other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsMeet)
			{
				this.IsMeet = other.IsMeet;
			}
			if (other.PerformanceId != 0U)
			{
				this.PerformanceId = other.PerformanceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008A5F RID: 35423 RVA: 0x0016D5CC File Offset: 0x0016B7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A60 RID: 35424 RVA: 0x0016D5D8 File Offset: 0x0016B7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PerformanceId = input.ReadUInt32();
					}
				}
				else
				{
					this.IsMeet = input.ReadBool();
				}
			}
		}

		// Token: 0x04003509 RID: 13577
		private static readonly MessageParser<NpcMeetByPerformanceStatus> _parser = new MessageParser<NpcMeetByPerformanceStatus>(() => new NpcMeetByPerformanceStatus());

		// Token: 0x0400350A RID: 13578
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400350B RID: 13579
		public const int IsMeetFieldNumber = 11;

		// Token: 0x0400350C RID: 13580
		private bool isMeet_;

		// Token: 0x0400350D RID: 13581
		public const int PerformanceIdFieldNumber = 15;

		// Token: 0x0400350E RID: 13582
		private uint performanceId_;
	}
}
