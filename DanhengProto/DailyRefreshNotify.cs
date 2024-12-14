using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000355 RID: 853
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DailyRefreshNotify : IMessage<DailyRefreshNotify>, IMessage, IEquatable<DailyRefreshNotify>, IDeepCloneable<DailyRefreshNotify>, IBufferMessage
	{
		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06002611 RID: 9745 RVA: 0x0006B138 File Offset: 0x00069338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DailyRefreshNotify> Parser
		{
			get
			{
				return DailyRefreshNotify._parser;
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x0006B13F File Offset: 0x0006933F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DailyRefreshNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06002613 RID: 9747 RVA: 0x0006B151 File Offset: 0x00069351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyRefreshNotify.Descriptor;
			}
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x0006B158 File Offset: 0x00069358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyRefreshNotify()
		{
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x0006B160 File Offset: 0x00069360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyRefreshNotify(DailyRefreshNotify other) : this()
		{
			this.curDay_ = other.curDay_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x0006B185 File Offset: 0x00069385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyRefreshNotify Clone()
		{
			return new DailyRefreshNotify(this);
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x0006B18D File Offset: 0x0006938D
		// (set) Token: 0x06002618 RID: 9752 RVA: 0x0006B195 File Offset: 0x00069395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurDay
		{
			get
			{
				return this.curDay_;
			}
			set
			{
				this.curDay_ = value;
			}
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x0006B19E File Offset: 0x0006939E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyRefreshNotify);
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x0006B1AC File Offset: 0x000693AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyRefreshNotify other)
		{
			return other != null && (other == this || (this.CurDay == other.CurDay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x0006B1DC File Offset: 0x000693DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurDay != 0U)
			{
				num ^= this.CurDay.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x0006B21B File Offset: 0x0006941B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x0006B223 File Offset: 0x00069423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x0006B22C File Offset: 0x0006942C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurDay != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.CurDay);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x0006B260 File Offset: 0x00069460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurDay != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurDay);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x0006B29E File Offset: 0x0006949E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyRefreshNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurDay != 0U)
			{
				this.CurDay = other.CurDay;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x0006B2CF File Offset: 0x000694CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x0006B2D8 File Offset: 0x000694D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CurDay = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000F77 RID: 3959
		private static readonly MessageParser<DailyRefreshNotify> _parser = new MessageParser<DailyRefreshNotify>(() => new DailyRefreshNotify());

		// Token: 0x04000F78 RID: 3960
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F79 RID: 3961
		public const int CurDayFieldNumber = 14;

		// Token: 0x04000F7A RID: 3962
		private uint curDay_;
	}
}
