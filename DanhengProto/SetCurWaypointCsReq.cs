using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010E5 RID: 4325
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetCurWaypointCsReq : IMessage<SetCurWaypointCsReq>, IMessage, IEquatable<SetCurWaypointCsReq>, IDeepCloneable<SetCurWaypointCsReq>, IBufferMessage
	{
		// Token: 0x1700366D RID: 13933
		// (get) Token: 0x0600C0D8 RID: 49368 RVA: 0x00206AA0 File Offset: 0x00204CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetCurWaypointCsReq> Parser
		{
			get
			{
				return SetCurWaypointCsReq._parser;
			}
		}

		// Token: 0x1700366E RID: 13934
		// (get) Token: 0x0600C0D9 RID: 49369 RVA: 0x00206AA7 File Offset: 0x00204CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetCurWaypointCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700366F RID: 13935
		// (get) Token: 0x0600C0DA RID: 49370 RVA: 0x00206AB9 File Offset: 0x00204CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetCurWaypointCsReq.Descriptor;
			}
		}

		// Token: 0x0600C0DB RID: 49371 RVA: 0x00206AC0 File Offset: 0x00204CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetCurWaypointCsReq()
		{
		}

		// Token: 0x0600C0DC RID: 49372 RVA: 0x00206AC8 File Offset: 0x00204CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetCurWaypointCsReq(SetCurWaypointCsReq other) : this()
		{
			this.aEHFBJKCPMB_ = other.aEHFBJKCPMB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C0DD RID: 49373 RVA: 0x00206AED File Offset: 0x00204CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetCurWaypointCsReq Clone()
		{
			return new SetCurWaypointCsReq(this);
		}

		// Token: 0x17003670 RID: 13936
		// (get) Token: 0x0600C0DE RID: 49374 RVA: 0x00206AF5 File Offset: 0x00204CF5
		// (set) Token: 0x0600C0DF RID: 49375 RVA: 0x00206AFD File Offset: 0x00204CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AEHFBJKCPMB
		{
			get
			{
				return this.aEHFBJKCPMB_;
			}
			set
			{
				this.aEHFBJKCPMB_ = value;
			}
		}

		// Token: 0x0600C0E0 RID: 49376 RVA: 0x00206B06 File Offset: 0x00204D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetCurWaypointCsReq);
		}

		// Token: 0x0600C0E1 RID: 49377 RVA: 0x00206B14 File Offset: 0x00204D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetCurWaypointCsReq other)
		{
			return other != null && (other == this || (this.AEHFBJKCPMB == other.AEHFBJKCPMB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C0E2 RID: 49378 RVA: 0x00206B44 File Offset: 0x00204D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AEHFBJKCPMB != 0U)
			{
				num ^= this.AEHFBJKCPMB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C0E3 RID: 49379 RVA: 0x00206B83 File Offset: 0x00204D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C0E4 RID: 49380 RVA: 0x00206B8B File Offset: 0x00204D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C0E5 RID: 49381 RVA: 0x00206B94 File Offset: 0x00204D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AEHFBJKCPMB != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.AEHFBJKCPMB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C0E6 RID: 49382 RVA: 0x00206BC8 File Offset: 0x00204DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AEHFBJKCPMB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AEHFBJKCPMB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C0E7 RID: 49383 RVA: 0x00206C06 File Offset: 0x00204E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetCurWaypointCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AEHFBJKCPMB != 0U)
			{
				this.AEHFBJKCPMB = other.AEHFBJKCPMB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C0E8 RID: 49384 RVA: 0x00206C37 File Offset: 0x00204E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C0E9 RID: 49385 RVA: 0x00206C40 File Offset: 0x00204E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AEHFBJKCPMB = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E27 RID: 20007
		private static readonly MessageParser<SetCurWaypointCsReq> _parser = new MessageParser<SetCurWaypointCsReq>(() => new SetCurWaypointCsReq());

		// Token: 0x04004E28 RID: 20008
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E29 RID: 20009
		public const int AEHFBJKCPMBFieldNumber = 2;

		// Token: 0x04004E2A RID: 20010
		private uint aEHFBJKCPMB_;
	}
}
