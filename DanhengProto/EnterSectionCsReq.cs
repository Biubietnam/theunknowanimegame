using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000467 RID: 1127
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterSectionCsReq : IMessage<EnterSectionCsReq>, IMessage, IEquatable<EnterSectionCsReq>, IDeepCloneable<EnterSectionCsReq>, IBufferMessage
	{
		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x0600322F RID: 12847 RVA: 0x0008A338 File Offset: 0x00088538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterSectionCsReq> Parser
		{
			get
			{
				return EnterSectionCsReq._parser;
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06003230 RID: 12848 RVA: 0x0008A33F File Offset: 0x0008853F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterSectionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06003231 RID: 12849 RVA: 0x0008A351 File Offset: 0x00088551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterSectionCsReq.Descriptor;
			}
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x0008A358 File Offset: 0x00088558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSectionCsReq()
		{
		}

		// Token: 0x06003233 RID: 12851 RVA: 0x0008A360 File Offset: 0x00088560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSectionCsReq(EnterSectionCsReq other) : this()
		{
			this.sectionId_ = other.sectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003234 RID: 12852 RVA: 0x0008A385 File Offset: 0x00088585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSectionCsReq Clone()
		{
			return new EnterSectionCsReq(this);
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06003235 RID: 12853 RVA: 0x0008A38D File Offset: 0x0008858D
		// (set) Token: 0x06003236 RID: 12854 RVA: 0x0008A395 File Offset: 0x00088595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SectionId
		{
			get
			{
				return this.sectionId_;
			}
			set
			{
				this.sectionId_ = value;
			}
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x0008A39E File Offset: 0x0008859E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterSectionCsReq);
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x0008A3AC File Offset: 0x000885AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterSectionCsReq other)
		{
			return other != null && (other == this || (this.SectionId == other.SectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x0008A3DC File Offset: 0x000885DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SectionId != 0U)
			{
				num ^= this.SectionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600323A RID: 12858 RVA: 0x0008A41B File Offset: 0x0008861B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x0008A423 File Offset: 0x00088623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600323C RID: 12860 RVA: 0x0008A42C File Offset: 0x0008862C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SectionId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.SectionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x0008A460 File Offset: 0x00088660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SectionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SectionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x0008A49E File Offset: 0x0008869E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterSectionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SectionId != 0U)
			{
				this.SectionId = other.SectionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x0008A4CF File Offset: 0x000886CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x0008A4D8 File Offset: 0x000886D8
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
					this.SectionId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001403 RID: 5123
		private static readonly MessageParser<EnterSectionCsReq> _parser = new MessageParser<EnterSectionCsReq>(() => new EnterSectionCsReq());

		// Token: 0x04001404 RID: 5124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001405 RID: 5125
		public const int SectionIdFieldNumber = 9;

		// Token: 0x04001406 RID: 5126
		private uint sectionId_;
	}
}
