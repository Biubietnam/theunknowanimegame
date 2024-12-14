using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F07 RID: 3847
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicScepterDressInUnitScRsp : IMessage<RogueMagicScepterDressInUnitScRsp>, IMessage, IEquatable<RogueMagicScepterDressInUnitScRsp>, IDeepCloneable<RogueMagicScepterDressInUnitScRsp>, IBufferMessage
	{
		// Token: 0x17003081 RID: 12417
		// (get) Token: 0x0600ABC4 RID: 43972 RVA: 0x001CE9A8 File Offset: 0x001CCBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicScepterDressInUnitScRsp> Parser
		{
			get
			{
				return RogueMagicScepterDressInUnitScRsp._parser;
			}
		}

		// Token: 0x17003082 RID: 12418
		// (get) Token: 0x0600ABC5 RID: 43973 RVA: 0x001CE9AF File Offset: 0x001CCBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicScepterDressInUnitScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003083 RID: 12419
		// (get) Token: 0x0600ABC6 RID: 43974 RVA: 0x001CE9C1 File Offset: 0x001CCBC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicScepterDressInUnitScRsp.Descriptor;
			}
		}

		// Token: 0x0600ABC7 RID: 43975 RVA: 0x001CE9C8 File Offset: 0x001CCBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterDressInUnitScRsp()
		{
		}

		// Token: 0x0600ABC8 RID: 43976 RVA: 0x001CE9D0 File Offset: 0x001CCBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterDressInUnitScRsp(RogueMagicScepterDressInUnitScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ABC9 RID: 43977 RVA: 0x001CE9F5 File Offset: 0x001CCBF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterDressInUnitScRsp Clone()
		{
			return new RogueMagicScepterDressInUnitScRsp(this);
		}

		// Token: 0x17003084 RID: 12420
		// (get) Token: 0x0600ABCA RID: 43978 RVA: 0x001CE9FD File Offset: 0x001CCBFD
		// (set) Token: 0x0600ABCB RID: 43979 RVA: 0x001CEA05 File Offset: 0x001CCC05
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

		// Token: 0x0600ABCC RID: 43980 RVA: 0x001CEA0E File Offset: 0x001CCC0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicScepterDressInUnitScRsp);
		}

		// Token: 0x0600ABCD RID: 43981 RVA: 0x001CEA1C File Offset: 0x001CCC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicScepterDressInUnitScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ABCE RID: 43982 RVA: 0x001CEA4C File Offset: 0x001CCC4C
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

		// Token: 0x0600ABCF RID: 43983 RVA: 0x001CEA8B File Offset: 0x001CCC8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ABD0 RID: 43984 RVA: 0x001CEA93 File Offset: 0x001CCC93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABD1 RID: 43985 RVA: 0x001CEA9C File Offset: 0x001CCC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ABD2 RID: 43986 RVA: 0x001CEAD0 File Offset: 0x001CCCD0
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

		// Token: 0x0600ABD3 RID: 43987 RVA: 0x001CEB0E File Offset: 0x001CCD0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicScepterDressInUnitScRsp other)
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

		// Token: 0x0600ABD4 RID: 43988 RVA: 0x001CEB3F File Offset: 0x001CCD3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABD5 RID: 43989 RVA: 0x001CEB48 File Offset: 0x001CCD48
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
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004616 RID: 17942
		private static readonly MessageParser<RogueMagicScepterDressInUnitScRsp> _parser = new MessageParser<RogueMagicScepterDressInUnitScRsp>(() => new RogueMagicScepterDressInUnitScRsp());

		// Token: 0x04004617 RID: 17943
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004618 RID: 17944
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04004619 RID: 17945
		private uint retcode_;
	}
}
