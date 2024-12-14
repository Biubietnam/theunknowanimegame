using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013CF RID: 5071
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnlockTutorialGuideCsReq : IMessage<UnlockTutorialGuideCsReq>, IMessage, IEquatable<UnlockTutorialGuideCsReq>, IDeepCloneable<UnlockTutorialGuideCsReq>, IBufferMessage
	{
		// Token: 0x17003F7C RID: 16252
		// (get) Token: 0x0600E20C RID: 57868 RVA: 0x002594F8 File Offset: 0x002576F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockTutorialGuideCsReq> Parser
		{
			get
			{
				return UnlockTutorialGuideCsReq._parser;
			}
		}

		// Token: 0x17003F7D RID: 16253
		// (get) Token: 0x0600E20D RID: 57869 RVA: 0x002594FF File Offset: 0x002576FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UnlockTutorialGuideCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F7E RID: 16254
		// (get) Token: 0x0600E20E RID: 57870 RVA: 0x00259511 File Offset: 0x00257711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockTutorialGuideCsReq.Descriptor;
			}
		}

		// Token: 0x0600E20F RID: 57871 RVA: 0x00259518 File Offset: 0x00257718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockTutorialGuideCsReq()
		{
		}

		// Token: 0x0600E210 RID: 57872 RVA: 0x00259520 File Offset: 0x00257720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockTutorialGuideCsReq(UnlockTutorialGuideCsReq other) : this()
		{
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E211 RID: 57873 RVA: 0x00259545 File Offset: 0x00257745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockTutorialGuideCsReq Clone()
		{
			return new UnlockTutorialGuideCsReq(this);
		}

		// Token: 0x17003F7F RID: 16255
		// (get) Token: 0x0600E212 RID: 57874 RVA: 0x0025954D File Offset: 0x0025774D
		// (set) Token: 0x0600E213 RID: 57875 RVA: 0x00259555 File Offset: 0x00257755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x0600E214 RID: 57876 RVA: 0x0025955E File Offset: 0x0025775E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockTutorialGuideCsReq);
		}

		// Token: 0x0600E215 RID: 57877 RVA: 0x0025956C File Offset: 0x0025776C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockTutorialGuideCsReq other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E216 RID: 57878 RVA: 0x0025959C File Offset: 0x0025779C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E217 RID: 57879 RVA: 0x002595DB File Offset: 0x002577DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E218 RID: 57880 RVA: 0x002595E3 File Offset: 0x002577E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E219 RID: 57881 RVA: 0x002595EC File Offset: 0x002577EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E21A RID: 57882 RVA: 0x00259620 File Offset: 0x00257820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E21B RID: 57883 RVA: 0x0025965E File Offset: 0x0025785E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockTutorialGuideCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E21C RID: 57884 RVA: 0x0025968F File Offset: 0x0025788F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E21D RID: 57885 RVA: 0x00259698 File Offset: 0x00257898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GroupId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040059EE RID: 23022
		private static readonly MessageParser<UnlockTutorialGuideCsReq> _parser = new MessageParser<UnlockTutorialGuideCsReq>(() => new UnlockTutorialGuideCsReq());

		// Token: 0x040059EF RID: 23023
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059F0 RID: 23024
		public const int GroupIdFieldNumber = 15;

		// Token: 0x040059F1 RID: 23025
		private uint groupId_;
	}
}
