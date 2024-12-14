using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000353 RID: 851
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DailyFirstMeetPamScRsp : IMessage<DailyFirstMeetPamScRsp>, IMessage, IEquatable<DailyFirstMeetPamScRsp>, IDeepCloneable<DailyFirstMeetPamScRsp>, IBufferMessage
	{
		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x0006AEC8 File Offset: 0x000690C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DailyFirstMeetPamScRsp> Parser
		{
			get
			{
				return DailyFirstMeetPamScRsp._parser;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x060025FD RID: 9725 RVA: 0x0006AECF File Offset: 0x000690CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DailyFirstMeetPamScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x0006AEE1 File Offset: 0x000690E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyFirstMeetPamScRsp.Descriptor;
			}
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x0006AEE8 File Offset: 0x000690E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyFirstMeetPamScRsp()
		{
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x0006AEF0 File Offset: 0x000690F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyFirstMeetPamScRsp(DailyFirstMeetPamScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x0006AF15 File Offset: 0x00069115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyFirstMeetPamScRsp Clone()
		{
			return new DailyFirstMeetPamScRsp(this);
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x0006AF1D File Offset: 0x0006911D
		// (set) Token: 0x06002603 RID: 9731 RVA: 0x0006AF25 File Offset: 0x00069125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x0006AF2E File Offset: 0x0006912E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyFirstMeetPamScRsp);
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x0006AF3C File Offset: 0x0006913C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyFirstMeetPamScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x0006AF6C File Offset: 0x0006916C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x0006AFAB File Offset: 0x000691AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x0006AFB3 File Offset: 0x000691B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x0006AFBC File Offset: 0x000691BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x0006AFF0 File Offset: 0x000691F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x0006B02E File Offset: 0x0006922E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyFirstMeetPamScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x0006B05F File Offset: 0x0006925F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x0006B068 File Offset: 0x00069268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000F72 RID: 3954
		private static readonly MessageParser<DailyFirstMeetPamScRsp> _parser = new MessageParser<DailyFirstMeetPamScRsp>(() => new DailyFirstMeetPamScRsp());

		// Token: 0x04000F73 RID: 3955
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F74 RID: 3956
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04000F75 RID: 3957
		private uint retcode_;
	}
}
