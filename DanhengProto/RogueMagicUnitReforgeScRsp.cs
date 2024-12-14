using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F31 RID: 3889
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicUnitReforgeScRsp : IMessage<RogueMagicUnitReforgeScRsp>, IMessage, IEquatable<RogueMagicUnitReforgeScRsp>, IDeepCloneable<RogueMagicUnitReforgeScRsp>, IBufferMessage
	{
		// Token: 0x170030F3 RID: 12531
		// (get) Token: 0x0600AD7D RID: 44413 RVA: 0x001D2868 File Offset: 0x001D0A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicUnitReforgeScRsp> Parser
		{
			get
			{
				return RogueMagicUnitReforgeScRsp._parser;
			}
		}

		// Token: 0x170030F4 RID: 12532
		// (get) Token: 0x0600AD7E RID: 44414 RVA: 0x001D286F File Offset: 0x001D0A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicUnitReforgeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030F5 RID: 12533
		// (get) Token: 0x0600AD7F RID: 44415 RVA: 0x001D2881 File Offset: 0x001D0A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicUnitReforgeScRsp.Descriptor;
			}
		}

		// Token: 0x0600AD80 RID: 44416 RVA: 0x001D2888 File Offset: 0x001D0A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitReforgeScRsp()
		{
		}

		// Token: 0x0600AD81 RID: 44417 RVA: 0x001D2890 File Offset: 0x001D0A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitReforgeScRsp(RogueMagicUnitReforgeScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD82 RID: 44418 RVA: 0x001D28B5 File Offset: 0x001D0AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitReforgeScRsp Clone()
		{
			return new RogueMagicUnitReforgeScRsp(this);
		}

		// Token: 0x170030F6 RID: 12534
		// (get) Token: 0x0600AD83 RID: 44419 RVA: 0x001D28BD File Offset: 0x001D0ABD
		// (set) Token: 0x0600AD84 RID: 44420 RVA: 0x001D28C5 File Offset: 0x001D0AC5
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

		// Token: 0x0600AD85 RID: 44421 RVA: 0x001D28CE File Offset: 0x001D0ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicUnitReforgeScRsp);
		}

		// Token: 0x0600AD86 RID: 44422 RVA: 0x001D28DC File Offset: 0x001D0ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicUnitReforgeScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD87 RID: 44423 RVA: 0x001D290C File Offset: 0x001D0B0C
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

		// Token: 0x0600AD88 RID: 44424 RVA: 0x001D294B File Offset: 0x001D0B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AD89 RID: 44425 RVA: 0x001D2953 File Offset: 0x001D0B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD8A RID: 44426 RVA: 0x001D295C File Offset: 0x001D0B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD8B RID: 44427 RVA: 0x001D2990 File Offset: 0x001D0B90
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

		// Token: 0x0600AD8C RID: 44428 RVA: 0x001D29CE File Offset: 0x001D0BCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicUnitReforgeScRsp other)
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

		// Token: 0x0600AD8D RID: 44429 RVA: 0x001D29FF File Offset: 0x001D0BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD8E RID: 44430 RVA: 0x001D2A08 File Offset: 0x001D0C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040046A1 RID: 18081
		private static readonly MessageParser<RogueMagicUnitReforgeScRsp> _parser = new MessageParser<RogueMagicUnitReforgeScRsp>(() => new RogueMagicUnitReforgeScRsp());

		// Token: 0x040046A2 RID: 18082
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046A3 RID: 18083
		public const int RetcodeFieldNumber = 13;

		// Token: 0x040046A4 RID: 18084
		private uint retcode_;
	}
}
